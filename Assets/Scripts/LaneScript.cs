using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class LaneScript : MonoBehaviour
{
    [Tooltip("Rotation speed in degrees per second")]
    public float rotationSpeed = 3f; // 90 degrees per second

    [Tooltip("Rotation axis (1 = rotate, 0 = no rotation)")]
    public Vector3 rotationAxis = Vector3.up; // Default: rotate around Y-axis

    void Update()
    {
        // Validate speed and axis
        if (rotationAxis == Vector3.zero || Mathf.Approximately(rotationSpeed, 0f))
            return;

        // Rotate at a constant speed regardless of frame rate
        transform.Rotate(rotationAxis.normalized * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
