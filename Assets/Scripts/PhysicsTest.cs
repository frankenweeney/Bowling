using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PhysicsTest : MonoBehaviour
{
    public Rigidbody rb;
    public float rollforce;
    public ForceMode ForceMode;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
    }


    public void RollLeft(InputAction.CallbackContext context)
    {
        rb.AddForce(Vector3.left * rollforce, ForceMode);
    }
    public void RollRight(InputAction.CallbackContext context)
    {
        rb.AddForce(Vector3.right * rollforce, ForceMode);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(rb.linearVelocity.magnitude > 0)
        {
          
        }
    }
}
