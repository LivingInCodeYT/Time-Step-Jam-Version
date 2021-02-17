using UnityEngine;

public class MainMenu : MonoBehaviour {
    private LevelLoader levelLoader;
    
    void Start() {
        levelLoader = FindObjectOfType<LevelLoader>();
    }
    public void Play() {
        Debug.Log("Play Pressed");
        levelLoader.LoadNextLevel();
    }
    public void Quit() {
        PlayerPrefs.Save();
        Application.Quit();
    }
}