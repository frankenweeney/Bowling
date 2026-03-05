using JetBrains.Annotations;
using UnityEditor.Rendering;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Camera camera;
    public Camera camera2;
    public GameObject ball;
    public Vector3 offset;
    private bool hasRun;
    void Start()
    {
        offset = camera.transform.position - ball.transform.position;
        camera.enabled = true;
        camera2.enabled = false;
        hasRun = false;
    }

    void Update()
    {
        camera.transform.position = ball.transform.position + offset;
    }
    public void ToggleCamera()
    {
        camera.enabled = !camera.enabled;
        camera2.enabled = !camera2.enabled;
        hasRun = true;
    }
}
