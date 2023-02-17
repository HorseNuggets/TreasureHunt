using UnityEngine;

public class PlayScript : MonoBehaviour {

    public void Click() {
        Destroy(transform.parent.parent.gameObject);
    }
}
