using UnityEngine;

using Backend;

public class ScriptCamera : MonoBehaviour
{
    private SourceNetwork networkThread;

    private float smooth = 2.0F;
    private float tiltAngle = 30.0F;

    void Start()
    {
        networkThread = new SourceNetwork();
    }

    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        if (networkThread.IsWorking)
            target = Quaternion.Euler(tiltAroundX, 0, (float)(networkThread.DataFloat * 0.01));

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
