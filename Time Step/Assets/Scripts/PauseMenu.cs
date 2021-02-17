using UnityEngine;

public class PauseMenu : MonoBehaviour {
    public static bool isPaused;
    public GameObject pausePanel;
    public KeyCode pauseKey;

    void Start() {
        pauseKey = KeyCode.Escape;
    }
    void Update() {
        if (Input.GetKeyDown(pauseKey)) {
            if (isPaused) {
                Unpause();
            } else {
                Pause();
            }
        }
    }
    void Pause() {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void Unpause() {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        isPaused = false;
    }
    public void MainMenu() {
        Unpause();
        StartCoroutine(FindObjectOfType<LevelLoader>().LoadLevel(0));
    }
    public void Quit() {
        Application.Quit();
    }
}