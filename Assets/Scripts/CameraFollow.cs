using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target (spaceship) for the camera to follow
    public Vector3 offset; // Offset position of the camera
    public float followSpeed = 5f; // Speed at which the camera follows

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position
            Vector3 desiredPosition = target.position + offset;

            // Smoothly interpolate the camera position
            transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

            // Optional: Look at the target
            transform.LookAt(target);
        }
    }
}
