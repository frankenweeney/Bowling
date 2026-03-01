using UnityEngine;

public class MenuCameraScript : MonoBehaviour
{
    public Camera camera;
    public float rotationSpeed;
    public Vector3 left;
    public Vector3 right;
    void Start()
    {
        left = new Vector3(0, -90, 0);
        right = new Vector3(0, 90, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            TurnLeft();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            TurnRight();    
        }
    }

    public void TurnLeft()
    {
        camera.transform.Rotate(left * rotationSpeed * Time.deltaTime);
    }

    public void TurnRight()
    {
        camera.transform.Rotate(right * rotationSpeed * Time.deltaTime);
    }
}
