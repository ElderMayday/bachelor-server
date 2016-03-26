﻿using System.Collections.Generic;
using System.Net;

using UnityEngine;

using Assets.Backend.Sources;
using Assets.Backend.Auxiliary;

namespace Assets.Scripts
{
    public class ScriptCamera : MonoBehaviour
    {
        private SourceNetwork source;

        void Start()
        {
            List<IPAddress> ipList = AddressProvider.GetLocalIp();

            source = new SourceNetwork(Axis.Yaw, ipList[ipList.Count - 1]);
            source.Start();

            UdpThread udpThread = new UdpThread();
            udpThread.Start();
        }

        void Update()
        {
            float smooth = 10.0f;
            float tiltAngle = 30.0f;

            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

            Backend.Auxiliary.Vector3 direction;
            direction = source.Direction;

            Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
            if (source.IsWorking)
                target = Quaternion.Euler((float)direction.X, (float)direction.Z, (float)direction.Y);

            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
    }
}
