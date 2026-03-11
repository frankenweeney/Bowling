using System.Globalization;
using Unity.VisualScripting;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PhysicsTest : MonoBehaviour
{
    public Rigidbody rb;
    public float rollforce;
    public ForceMode ForceMode;
    public bool pinsStruck = false;

    public Material currentMaterial;
    public Material gorillaz;
    public Material leon;
    public Material minecraft;
    public Material regular;
    public Material swag;
    public Material twinpeaks;
    public Material ball7;
    public Material ball8;
    int currentBall = PlayerPrefs.GetInt("ballNumber");

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.GetComponent<Renderer>().material = currentMaterial;
        
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

    private void Update()
    {
        if (currentBall == 1)
        {
            currentMaterial = gorillaz;
        }
        if (currentBall == 2)
        {
            currentMaterial = leon;
        }
        if (currentBall == 3)
        {
            currentMaterial = minecraft;
        }
        if (currentBall == 4)
        {
            currentMaterial = regular;
        }
        if (currentBall == 5)
        {
            currentMaterial = swag;
        }
        if (currentBall == 6)
        {
            currentMaterial = twinpeaks;
        }
        if (currentBall == 7)
        {
            currentMaterial = ball7;
        }
        if (currentBall == 8)
        {
            currentMaterial = ball8;
        }
    }
  
}
