
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

    public Transform[] waypoints;
    public float speed = 2f; 
    private int currentWaypointIndex = 0;

    public bool launched = false;
    public bool held = false;

    public void Start()
    {
        progressBar.fillAmount = 0;
        held = false;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startTime = Time.time;
            timer = startTime;
            held = true;
        }

        if (Input.GetKey(KeyCode.Space) && launched == false)
        {
            timer += Time.deltaTime;
            progressBar.fillAmount += Time.deltaTime / holdTime;
            force += (Time.deltaTime / holdTime) * 400000;

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

        if (held == false)
        {
            if (waypoints.Length == 0) return;
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
            {
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; 
            }
        }

    }

    public void ButtoHeld()
    {
        rb.AddForce(Vector3.forward * force, ForceMode.Force);
        launched = true;
    }
}