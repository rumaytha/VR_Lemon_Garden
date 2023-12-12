using UnityEngine;

public class VRFirstPersonController : MonoBehaviour
{
    // Variables for movement
    private Rigidbody rb;
    private float movementSpeed = 10.0f;

    // Variables for rotation
    private float rotationSpeed = 100.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Freeze rotation on all axes for the Rigidbody
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        // Gather input from the right thumbstick for movement
        Vector2 movementThumbstick = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick); // Right-hand controller
        float moveHorizontal = movementThumbstick.x;
        float moveVertical = movementThumbstick.y;

        // Gather input from the left thumbstick for rotation
        Vector2 rotationThumbstick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick); // Left-hand controller
        float rotateHorizontal = rotationThumbstick.x;

        // Calculate movement direction based on controller input
        Vector3 movementDirection = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        // Rotate the movement direction based on the player's rotation
        movementDirection = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0) * movementDirection;

        // Move the player based on the calculated direction using Rigidbody
        rb.MovePosition(rb.position + movementDirection * movementSpeed * Time.fixedDeltaTime);

        // Rotate the player based on the left thumbstick input using Rigidbody
        rb.MoveRotation(rb.rotation * Quaternion.Euler(Vector3.up * rotateHorizontal * rotationSpeed * Time.fixedDeltaTime));
    }
}
