
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class LaunchScript : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public ForceMode ForceMode;
    public Image progressBar;

    private float startTime = 0f;
    private float timer = 0f;
    public float holdTime = 2.0f;

  
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

        if (Input.GetKey(KeyCode.Space) && launched == false)
        {
            timer += Time.deltaTime;
            progressBar.fillAmount += Time.deltaTime / holdTime;
            force += (Time.deltaTime / holdTime) * 100000;

            if (timer > (startTime + holdTime))
            {
                ButtoHeld();
            }
        }

        if (Input.GetKeyUp(KeyCode.Space) && launched == false)
        {
            ButtoHeld();
            progressBar.fillAmount = 0;
        }

    }

    public void ButtoHeld()
    {
        rb.AddForce(Vector3.forward * force, ForceMode.Force);
        launched = true;
    }
}