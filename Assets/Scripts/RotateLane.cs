using System.Collections;
using UnityEngine;

public class RotateLane : MonoBehaviour
{
    public float rotationSpeed = 3f;

    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        if (rotationAxis == Vector3.zero || Mathf.Approximately(rotationSpeed, 0f))
            return;

        transform.Rotate(rotationAxis.normalized * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
