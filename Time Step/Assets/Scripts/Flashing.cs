using UnityEngine;
using UnityEngine.UI;

public class Flashing : MonoBehaviour {
    public Image image;
    public float flashRate;

    public void Start() {
        Invoke("TurnOn", flashRate);
    }
    void TurnOn() {
        image.enabled = true;
        Invoke("TurnOff", flashRate);
    }
    void TurnOff() {
        image.enabled = false;
        Invoke("TurnOn", flashRate);
    }
}