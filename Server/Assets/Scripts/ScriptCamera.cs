using System.Collections.Generic;
using System.Net;

using UnityEngine;

using Assets.Backend.Sources;
using Assets.Backend.Auxiliary;
using Assets.Backend.Filters;
using System;

namespace Assets.Scripts
{
    /// <summary>
    /// Скрипт камеры
    /// </summary>
    public class ScriptCamera : MonoBehaviour
    {
        private SourceNetwork source;
        private Filter filterX, filterY, filterZ;

        /// <summary>
        /// Метод запука скрипта
        /// </summary>
        private void Start()
        {
            LaunchScript data = GameObject.Find("LaunchManager").GetComponent<LaunchScript>();

            Debug.Log("FilterType=" + data.filterType.ToString());

            Debug.Log("FilterLength=" + data.filterLength.ToString());

            Debug.Log("FilterParameter=" + String.Format("{0:0.000}", data.filterParameter));

            List<IPAddress> ipList = AddressProvider.GetLocalIp();

            source = new SourceNetwork(RotationAxis.Yaw, ipList[ipList.Count - 1]);
            source.Start();

            UdpThread udpThread = new UdpThread();
            udpThread.Start();

            filterX = new FilterMovingAverage(5);
            filterY = new FilterMovingAverage(5);
            filterZ = new FilterMovingAverage(5);
        }


        /// <summary>
        /// Метода-обработчик обновления кадра
        /// </summary>
        private void Update()
        {
            float smooth = 10.0f;
            float tiltAngle = 30.0f;

            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

            Backend.Auxiliary.Vector3 direction;
            direction = source.Direction;

            Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
            if (source.IsCorrect)
            {
                filterX.AddInput(direction.X);
                filterY.AddInput(direction.Y);
                filterZ.AddInput(direction.Z);
                target = Quaternion.Euler((float)filterX.GetOutput(), (float)filterZ.GetOutput(), (float)filterY.GetOutput());
            }

            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);


            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Destroy(GameObject.Find("LaunchManager"));
                Application.LoadLevel("LaunchScene");
            }
        }
    }
}
