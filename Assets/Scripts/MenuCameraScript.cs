using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MenuCameraScript : MonoBehaviour
{
    public Camera camera;
    public float rotationSpeed = 90;
 
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            RotateCamera(-1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RotateCamera(1);
        }
    }

    private void RotateCamera(int direction)
    {
        transform.Rotate(Vector3.up * direction * rotationSpeed * Time.deltaTime);
    }
}
