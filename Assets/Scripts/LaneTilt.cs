using System;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;


public class LaneTilt : MonoBehaviour
{

    public float maxX = 50f;
    public float minX = -50f;

    private float xRotation = 0f;

    void Update()
    {

        xRotation = Mathf.Clamp(xRotation, minX, maxX);

    }
}
