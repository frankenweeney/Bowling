using System;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;


public class LaneTilt : MonoBehaviour
{
    public Rigidbody rb;
    public float maxX = 50f;
    public float minX = -50f;

    private float xRotation = 0f;

    private void Start()
    {
       
    }
    void Update()
    {

        xRotation = Mathf.Clamp(xRotation, minX, maxX);

    }
}
