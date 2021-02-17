using UnityEngine;

public class TimeSwitch : MonoBehaviour {
    public GameObject time1;
    public GameObject time2;
    public GameObject active;
    
    void Start() {
        active = time1;
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            if (active == time1) {
                active = time2;
                time1.SetActive(false);
                time2.SetActive(true);
            } else {
                active = time1;
                time1.SetActive(true);
                time2.SetActive(false);
            }
        }
    }

}