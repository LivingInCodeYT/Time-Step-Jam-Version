using UnityEngine;

public class EnableAfter : MonoBehaviour {
    public float enableAfterSeconds = 10f;
    public GameObject toEnable;

    void Start() {
        Invoke("Enable", enableAfterSeconds);
    }
    void Enable() {
        toEnable.SetActive(true);
    }
}