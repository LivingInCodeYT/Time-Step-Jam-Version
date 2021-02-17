using UnityEngine;

public class EndScreen : MonoBehaviour {
    public void MainMenu() {
        StartCoroutine(FindObjectOfType<LevelLoader>().LoadLevel(0));
    }
}
