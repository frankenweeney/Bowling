
using TMPro;
using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class LaunchScript : MonoBehaviour
{
    public Rigidbody rb;
    public Collider boost;
    public float force;
    public ForceMode ForceMode;
    public Image progressBar;
    public Image levelBar;

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
        rb.useGravity = false;
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
                Launch();
            }
        }

        if (Input.GetKeyUp(KeyCode.Space) && launched == false)
        {
            Launch();
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

    public void OnTriggerEnter(Collider other)
    {
        launched = false;
        ShowProgressBars();
        force = 0;
        progressBar.fillAmount = 0;
    }

    public void OnTriggerExit(Collider other)
    {
        HideProgressBars();
        launched = true;
    }

    public void Launch()
    {
        rb.useGravity = true;
        rb.AddForce(Vector3.forward * force, ForceMode.Force);
        launched = true;
        HideProgressBars();
    }

    public void HideProgressBars()
    {
        levelBar.enabled = false;
        progressBar.enabled = false;
    }

    public void ShowProgressBars()
    {
        levelBar.enabled = true;
        progressBar.enabled = true;
    }
}