using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject treasuresContainer;

    private bool gameIsOver = false;

    private void Update() {
        if (!gameIsOver && treasuresContainer.transform.childCount == 0) {
            gameIsOver = true;

            Debug.Log("You win!");
            Application.Quit();
        }
    }
}
