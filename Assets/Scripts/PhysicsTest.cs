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

    public Material gorillaz;
    public Material leon;
    public Material minecraft;
    public Material regular;
    public Material swag;
    public Material twinpeaks;
    public Material horseball;
    public Material galaxy;
    public bool ballApplied = false;
    public int currentBall;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentBall = PlayerPrefs.GetInt("ballNumber");
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
        if (ballApplied ==  false)
        {
            if (currentBall == 1)
            {
                rb.GetComponent<Renderer>().material = gorillaz;
                ballApplied = true;
            }
            if (currentBall == 2)
            {
                rb.GetComponent<Renderer>().material = leon;
                ballApplied = true;
            }
            if (currentBall == 3)
            {
                rb.GetComponent<Renderer>().material = minecraft;
                ballApplied = true;
            }
            if (currentBall == 4)
            {
                rb.GetComponent<Renderer>().material = regular;
                ballApplied = true;
            }
            if (currentBall == 5)
            {
                rb.GetComponent<Renderer>().material = swag;
                ballApplied = true;
            }
            if (currentBall == 6)
            {
                rb.GetComponent<Renderer>().material = twinpeaks;
                ballApplied = true;
            }
            if (currentBall == 7)
            {
                rb.GetComponent<Renderer>().material = horseball;
                ballApplied = true;
            }
            if (currentBall == 8)
            {
                rb.GetComponent<Renderer>().material = galaxy;
                ballApplied = true;
            }
        }
    }
  
}
