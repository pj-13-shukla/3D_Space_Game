using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float thrustForce = 10f;  // Speed of movement
    public float rotationSpeed = 100f; // Speed of rotation
    public GameObject projectilePrefab; // Reference to the projectile prefab
    public Transform firePoint; // Point from where projectiles are fired
    public float cooldownTime = 1f; // Time between shots
    private float lastShotTime;

    void Update()
    {
        HandleMovement();
        HandleShooting();
    }

    void HandleMovement()
    {
        // Get input for thrust (W/S keys or joystick)
        float thrustInput = Input.GetAxis("Vertical");
        Vector3 thrust = transform.forward * thrustInput * thrustForce * Time.deltaTime;
        transform.position += thrust;

        // Get input for rotation (A/D keys or joystick)
        float rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, rotationInput * rotationSpeed * Time.deltaTime, 0);
    }

    void HandleShooting()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= lastShotTime + cooldownTime)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        lastShotTime = Time.time;
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
