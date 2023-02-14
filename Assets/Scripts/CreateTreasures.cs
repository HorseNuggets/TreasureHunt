using UnityEngine;

public class CreateTreasures : MonoBehaviour {

    public GameObject treasurePrefab;
    public GameObject treasuresContainer;
    public int numberOfTreasures = 5;

    private Vector3 RandomPosition() {
        return new Vector3(Random.Range(-20, 20), 0.5f, Random.Range(-20, 20));
    }

    void Start() {
        for (int i = 0; i < numberOfTreasures; i++) {
            Instantiate(treasurePrefab, RandomPosition(), Quaternion.identity, treasuresContainer.transform);
        }
    }
}
