using UnityEngine;

public class MoveCamera : MonoBehaviour {
    public Vector3 dest;
    public float maxDistanceDelta;
    public Vector3 doorOpenPos;
    public Vector3 doorClosedPos;

    void Update() {

        transform.position = Vector3.MoveTowards(transform.position, dest, maxDistanceDelta);
        
    }

    public void OpenDoor() {
        dest = doorOpenPos;
    }
    public void CloseDoor() {
        dest = doorClosedPos;
    }
    public void MoveCam(Vector3 pos) {
        dest = pos;
    }
}