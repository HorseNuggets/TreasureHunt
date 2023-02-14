using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 6f;
    public float mouseSensitivity = 2f;

    private CharacterController characterController;
    private Transform cameraTransform;

    private void Start() {
        characterController = GetComponent<CharacterController>();
        cameraTransform = GetComponentInChildren<Camera>().transform;
    }

    private void Update() {

        // Get input axis for movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized;
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;

        // Apply movement
        characterController.Move(moveDirection * Time.deltaTime);

        // Get mouse input for rotation
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calculate rotation
        Vector3 playerRotation = new Vector3(0, mouseX * mouseSensitivity, 0);
        cameraTransform.Rotate(-mouseY * mouseSensitivity, 0, 0);

        // Apply rotation
        transform.Rotate(playerRotation);
    }
}
