using JetBrains.Annotations;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Camera camera;
    public GameObject ball;
    public Vector3 offset;
    void Start()
    {
        offset = camera.transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = ball.transform.position + offset;
    }
}
