using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PhysicsTest : MonoBehaviour
{
    public Rigidbody rb;
    public float rollforce;
    public ForceMode ForceMode;
    public bool pinsStruck = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && pinsStruck == false)
        {
            rb.AddForce(Vector3.left * rollforce, ForceMode);
        }

        if (Input.GetKey(KeyCode.RightArrow) && pinsStruck == false)
        {
            rb.AddForce(Vector3.right * rollforce, ForceMode);
        }
    }
  
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Pin"))
        {
          pinsStruck = true;
        }
    }
}
