using UnityEngine;

public class MaxSpeed : MonoBehaviour {
    Rigidbody2D rb;
    public float maxSpeed;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        if (rb.velocity.x > maxSpeed) {
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        }
    }
}