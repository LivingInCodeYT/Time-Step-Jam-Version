using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour {
    public LevelLoader levelLoader;
    public GameObject[] textElements;
    private int textIndex;

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            if (textIndex == (textElements.Length - 1)) {levelLoader.LoadNextLevel(); Destroy(gameObject);}
            textElements[textIndex].SetActive(false);
            textIndex++;
            textElements[textIndex].SetActive(true);
        }
    }
}