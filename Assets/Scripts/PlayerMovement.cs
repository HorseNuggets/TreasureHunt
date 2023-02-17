using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed = 15.0f;
    public float mouseSensitivity = 2f;

    private CharacterController controller;
    private Transform player;
    private OVRCameraRig rig;
    private Transform cameraTransform;
    private float rotY = 0.0f;

    void Start() {
        controller = GetComponent<CharacterController>();
        player = GetComponent<Transform>();
        rig = GetComponent<OVRCameraRig>();

        GameObject centerEyeAnchor = GameObject.Find("CenterEyeAnchor");

        cameraTransform = centerEyeAnchor.GetComponent<Camera>().transform;

        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;
    }

    private void ApplyGravity() {
        controller.Move(Vector3.down * 9.81f * Time.deltaTime);
    }

    void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        ApplyGravity();
        
        Vector3 forward = rig.centerEyeAnchor.forward;
        Vector3 right = rig.centerEyeAnchor.right;
        Vector3 movement = (forward * verticalInput + right * horizontalInput);

        movement.y = 0;
        movement.Normalize();
        movement *= movementSpeed * Time.deltaTime;

        controller.Move(movement);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 playerRotation = new Vector3(0, mouseX * mouseSensitivity, 0);

        transform.Rotate(playerRotation);

        rotY += -mouseY * mouseSensitivity;
        rotY = Mathf.Clamp(rotY, -90, 90);

        cameraTransform.localEulerAngles = new Vector3(rotY, 0, 0);
    }
}
