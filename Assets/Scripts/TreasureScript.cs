using UnityEngine;

public class TreasureScript : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            Destroy(this.gameObject);
        }
    }
}
