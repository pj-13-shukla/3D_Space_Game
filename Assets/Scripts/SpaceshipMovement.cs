using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    // Public variables for speed and joystick
    public float moveSpeed = 10f;  // Adjust speed as needed
    public Joystick joystick;  // Reference to the mobile joystick component
    private Rigidbody rb;  // Rigidbody for 3D physics

    // Automatically assign Rigidbody component at the start
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Automatically assigns the Rigidbody component
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the joystick's Horizontal and Vertical axes
        float horizontalMove = joystick.Horizontal;
        float verticalMove = joystick.Vertical;

        // Apply movement based on joystick input
        Vector3 movement = new Vector3(horizontalMove, 0f, verticalMove);  // No movement on the Y-axis in a 3D space

        // Set velocity of the Rigidbody
        rb.linearVelocity = movement * moveSpeed;

        // Optional: Rotate the spaceship in the direction of movement
        if (movement != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            rb.rotation = Quaternion.Slerp(rb.rotation, targetRotation, Time.deltaTime * 5f);
        }
    }
} // <-- This is the closing brace for the class
