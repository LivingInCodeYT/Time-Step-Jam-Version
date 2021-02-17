using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class EndDoor : MonoBehaviour {
    public LevelLoader LevelLoader;
    
    void Start() {
        LevelLoader = FindObjectOfType<LevelLoader>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            NextLevel();
        }
    }
    void NextLevel() {
        LevelLoader.LoadNextLevel();
    }   
}