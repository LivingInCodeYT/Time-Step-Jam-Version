using UnityEngine;

public class MusicSystem : MonoBehaviour {
    void Start() {
        DontDestroyOnLoad(gameObject);
    }
}