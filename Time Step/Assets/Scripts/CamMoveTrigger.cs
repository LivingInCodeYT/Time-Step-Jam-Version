using UnityEngine;

public class CamMoveTrigger : MonoBehaviour {
    public MoveCamera camScriptMove;
    public Vector3 newCamPos;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            camScriptMove.MoveCam(newCamPos);
        }
    }
}