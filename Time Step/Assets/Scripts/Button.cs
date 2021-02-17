using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour {
    public UnityEvent onPressButton;
    public UnityEvent onUnpressButton;

    void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Box")) {
            pressButton();
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Box")) {
            unPressButton();
        }
    }
    void pressButton() {
        onPressButton.Invoke();
    }
    void unPressButton() {
        onUnpressButton.Invoke();
    }
}