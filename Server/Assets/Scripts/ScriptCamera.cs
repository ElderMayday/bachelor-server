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

            setFilters(data);
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

            Quaternion target; 

            if (source.IsCorrect)
            {
                filterX.AddInput(direction.X);
                filterY.AddInput(direction.Y);
                filterZ.AddInput(direction.Z);
                target = Quaternion.Euler((float)filterX.GetOutput(), (float)filterZ.GetOutput(), (float)filterY.GetOutput());
            }
            else
                target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                source.Stop();
                Destroy(GameObject.Find("LaunchManager"));
                Application.LoadLevel("LaunchScene");
            }
        }

        /// <summary>
        /// Устанавлиает фильтры
        /// </summary>
        private void setFilters(LaunchScript data)
        {
            switch (data.filterType)
            {
                case FilterType.MovingAverage:
                    {
                        filterX = new FilterMovingAverage(data.filterLength);
                        filterY = new FilterMovingAverage(data.filterLength);
                        filterZ = new FilterMovingAverage(data.filterLength);
                    }
                    break;
                case FilterType.SignlePole:
                    {
                        filterX = new FilterSinglePole(data.filterLength, data.filterParameter);
                        filterY = new FilterSinglePole(data.filterLength, data.filterParameter);
                        filterZ = new FilterSinglePole(data.filterLength, data.filterParameter);
                    }
                    break;
                case FilterType.Gaussian:
                    {
                        filterX = new FilterGaussian(data.filterLength, data.filterParameter);
                        filterY = new FilterGaussian(data.filterLength, data.filterParameter);
                        filterZ = new FilterGaussian(data.filterLength, data.filterParameter);
                    }
                    break;
            }
        }



        /// <summary>
        /// Источник данных
        /// </summary>
        private SourceNetwork source;

        /// <summary>
        /// Фильтры по всем осям
        /// </summary>
        private Filter filterX, filterY, filterZ;
    }
}
