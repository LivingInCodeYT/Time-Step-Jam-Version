using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    public Transform[] points;
    public int currentPointIndex = 0;
    public float speed = 0;

    void Update() {
        transform.position = Vector2.MoveTowards(transform.position, points[currentPointIndex].position, speed);
        if (transform.position == points[currentPointIndex].position) {
            currentPointIndex++;
        }

        if (currentPointIndex == points.Length) {
            currentPointIndex = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            other.GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity;
        }
    }
}