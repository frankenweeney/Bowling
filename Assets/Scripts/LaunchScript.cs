
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LaunchScript : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public ForceMode ForceMode;
    public Image progressBar;

    private float startTime = 0f;
    private float timer = 0f;
    public float holdTime = 4.0f;
  

    private bool held = false;
    public bool launched = false;


    public void Start()
    {
        progressBar.fillAmount = 0;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startTime = Time.time;
            timer = startTime;
        }

        if (Input.GetKey(KeyCode.Space) && held == false)
        {
            timer += Time.deltaTime;

            if (timer > (startTime + holdTime))
            {
                held = true;
                ButtoHeld();
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            held = false;
            held = false;
            progressBar.fillAmount = 0;
        }

    }

    public void FixedUpdate()
    {
        if (launched == true)
        {
            rb.AddForce(Vector3.forward * force, ForceMode.Force);
        }
    }

    public void ButtoHeld()
    {
        launched = true;
    }
}