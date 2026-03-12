using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class HorseScript : MonoBehaviour
{
    public Transform player;
    public Transform shelf;
    public float rotationSpeed = 0.1f;
    void Start()
    {
        
    }

    void Update()
    {
        if (player.rotation.eulerAngles.y > 170 && transform.rotation.eulerAngles.y < 260)
        {
            // Calculate direction to target
            Vector3 direction = player.position - transform.position;

            // Compute step size for smooth rotation
            float step = rotationSpeed * Time.deltaTime;

            // Gradually rotate towards target
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, direction, step, 0.0f);

            // Apply rotation
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
        else
        {
            // Calculate direction to target
            Vector3 direction = shelf.position - transform.position;

            // Compute step size for smooth rotation
            float step = rotationSpeed * Time.deltaTime;

            // Gradually rotate towards target
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, direction, step, 0.0f);

            // Apply rotation
            transform.rotation = Quaternion.LookRotation(newDirection);
        }

    }
}
