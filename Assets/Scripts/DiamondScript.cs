using UnityEngine;

public class DiamondScript : MonoBehaviour {
    
    private void OnCollisionEnter(Collision other) {
        Debug.Log(other);

        if (other.gameObject.tag == "Player") {
            Destroy(this.gameObject);
        }
    }
}
