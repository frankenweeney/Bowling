using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform[] waypoints; // Points the platform will move between
    public float speed = 2f; // Speed of the platform
    private int currentWaypointIndex = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;

        // Move towards the current waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);

        // Check if the platform reached the waypoint
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; // Loop to the next waypoint
        }
    }
}