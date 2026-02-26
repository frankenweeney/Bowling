using System;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;


public class LaneTilt : MonoBehaviour
{
 
    public float tiltAmount = 10f;
    public float tiltSpeed = 5f;
    public float maxTiltAngle = 20f;

    public Rigidbody rb;
    private Quaternion targetRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        targetRotation = transform.rotation;
    }

    void FixedUpdate()
    {
        Vector3 acceleration = rb.linearVelocity - Physics.gravity * Time.fixedDeltaTime;

        Vector3 localAccel = transform.InverseTransformDirection(acceleration);

        float tiltX = Mathf.Clamp(-localAccel.z * tiltAmount, -maxTiltAngle, maxTiltAngle);
        float tiltZ = Mathf.Clamp(localAccel.x * tiltAmount, -maxTiltAngle, maxTiltAngle);


        targetRotation = Quaternion.Euler(tiltX, transform.eulerAngles.y, tiltZ);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.fixedDeltaTime * tiltSpeed);
    }
}
