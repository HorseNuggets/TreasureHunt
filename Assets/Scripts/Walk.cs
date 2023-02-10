using UnityEngine;

public class Walk : MonoBehaviour {

    public Rigidbody rb;
    public float force = 100f;
    public Vector3 centerOfMass;

    void Start() {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centerOfMass;
    }

    void FixedUpdate() {
        if (Input.GetKey(KeyCode.W)) {
            rb.AddForce(0, 0, force);
        }

        if (Input.GetKey(KeyCode.A)) {
            rb.AddForce(-force, 0, 0);
        }

        if (Input.GetKey(KeyCode.S)) {
            rb.AddForce(0, 0, -force);
        }

        if (Input.GetKey(KeyCode.D)) {
            rb.AddForce(force, 0, 0);
        }
    }
}
