using UnityEngine;

public class BouncePad : MonoBehaviour {

    void OnTriggerStay2D(Collider2D other) {
        Debug.Log("Collided");
        if (other.CompareTag("Player")) {
            other.GetComponent<PlayerMovement>().enabled = false;
            other.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10);
        }
    }
}