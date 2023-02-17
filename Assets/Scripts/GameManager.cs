using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject diamondsContainer;
    public GameObject canvas;
    public GameObject winScreen;

    private CreateDiamonds createDiamonds;
    private bool gameIsOver = false;

    void Start() {
        StartGame();
    }

    void StartGame() {
        gameIsOver = false;
        createDiamonds = diamondsContainer.GetComponent<CreateDiamonds>();

        Instantiate(canvas, Vector3.zero, Quaternion.identity);
    }

    void Exit() {
        Application.Quit();
    }

    void Update() {
        if (!gameIsOver && diamondsContainer.transform.childCount == 0 && createDiamonds.loaded) {
            gameIsOver = true;

            Instantiate(winScreen, Vector3.zero, Quaternion.identity);

            Invoke("Exit", 3);
        }
    }
}
