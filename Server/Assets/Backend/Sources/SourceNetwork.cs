﻿using System;
using System.Text;
using System.Globalization;

using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace Assets.Backend.Sources
{
    public class SourceNetwork : Source
    {
        public SourceNetwork(Axis _axis, IPAddress _ipAddress) : base()
        {
            IsWorking = false;
            IsCorrect = true;
            axis = _axis;
            thread.Name = "SourceNetwork";
            ipAddress = _ipAddress;
            localIp = AddressProvider.GetLocalIp();
        }

        public override void Stop()
        {
            mustWork = false;

            try
            {
                socketListener.Shutdown(SocketShutdown.Both);        
            }
            catch (Exception e)
            {
                exception = e;
            }

            socketListener.Close();

            thread.Join();
        }

        

        protected override void doThread()
        {
            try
            {
                while (mustWork)
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 11000);
                    socketListener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    socketListener.Bind(ipEndPoint);
                    socketListener.Listen(10);

                    Socket socketHandler = socketListener.Accept();
                    socketHandler.ReceiveTimeout = 1000;

                    IsWorking = true;
                    IsCorrect = true;

                    while (mustWork)
                    {
                        byte[] bytes = new byte[1024];
                        int bytesLength = socketHandler.Receive(bytes);

                        string stringOriginal = Encoding.UTF8.GetString(bytes, 0, bytesLength);
                        string stringEdited;

                        int index1 = stringOriginal.IndexOf('<');
                        int index2 = stringOriginal.IndexOf('>');

                        if ((index1 != -1) && (index2 != -1) && (index2 >= index1))
                            stringEdited = stringOriginal.Substring(index1 + 1, index2 - index1 - 1);
                        else
                        {
                            IsCorrect = false;
                            throw new Exception("Block borders are not found");
                        }

                        string[] parameters = stringEdited.Split(';');

                        try
                        {
                            pitch = Single.Parse(parameters[0], CultureInfo.InvariantCulture);
                            roll = Single.Parse(parameters[1], CultureInfo.InvariantCulture);
                            yaw = Single.Parse(parameters[2], CultureInfo.InvariantCulture);
                            IsCorrect = true;
                        }
                        catch (FormatException e)
                        {
                            IsCorrect = false;
                        }

                        switch (axis)
                        {
                            case Axis.Pitch: Data = pitch; break;
                            case Axis.Roll: Data = roll; break;
                            case Axis.Yaw: Data = yaw; break;
                        }

                        if (bytesLength == 0)
                            break;
                    }

                    IsWorking = false;
                    IsCorrect = true;
                    socketListener.Close();
                    ipEndPoint = null;
                }
            }
            catch (Exception e)
            {
                exception = e;
            }
        }

        protected IPAddress ipAddress;
        protected List<IPAddress> localIp;
        protected Socket socketListener;
        protected Exception exception;
        protected float pitch, roll, yaw;
        protected Axis axis;
    }
}