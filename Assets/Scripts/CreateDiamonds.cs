using UnityEngine;

public class CreateDiamonds : MonoBehaviour {

    public GameObject diamondPrefab;
    public int numberOfDiamonds = 3;
    public bool loaded = false;

    private Vector3 RandomPosition() {
        Vector3 result = Vector3.zero;

        while (result == Vector3.zero || Physics.CheckBox(result, Vector3.one * 0.5f) || result.magnitude < 6) {
            result = new Vector3(Random.Range(-18, 18), 5, Random.Range(-18, 18));
        }

        return result;
    }

    void Start() {
        for (int i = 0; i < numberOfDiamonds; i++) {
            Instantiate(diamondPrefab, RandomPosition(), Quaternion.identity, transform);
        }

        loaded = true;
    }
}
