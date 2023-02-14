using UnityEngine;

public class TreasureScript : MonoBehaviour {
    
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            Destroy(this.gameObject);
        }
    }
}
