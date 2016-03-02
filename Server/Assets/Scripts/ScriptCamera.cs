using UnityEngine;

using Assets.Backend.Sources;
using System.Collections.Generic;
using System.Net;
using Assets.Backend;

namespace Assets.Scripts
{
    public class ScriptCamera : MonoBehaviour
    {
        private Source source;

        private float smooth = 10.0F;
        private float tiltAngle = 30.0F;

        void Start()
        {
            List<IPAddress> ipList = AddressProvider.GetLocalIp();

            source = new SourceNetwork(Axis.Pitch, ipList[ipList.Count - 1]);
            source.Start();
        }

        void Update()
        {
            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
            Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

            if (source.IsWorking)
                target = Quaternion.Euler(0, 0, (float)(source.Data));

            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
    }
}
