using UnityEngine;

public class EnemyAttack : MonoBehaviour {
    private Rigidbody2D rb;
    private bool isAttacking;
    public float speed;
    
    void Start() {
        rb = transform.parent.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0f);
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            if (!isAttacking) {
                other.GetComponent<PlayerDeath>().health--;
                if (other.GetComponent<PlayerDeath>().health == 0) other.GetComponent<PlayerDeath>().Die();
                isAttacking = true;
                Invoke("ResetAttack", 1f);
            }
        } else if (!other.CompareTag("NotWall")) {
            if (rb.velocity.x == speed) {
                rb.velocity = new Vector2(-speed, 0f);
                transform.parent.localScale = new Vector3(-1f, 1f, 1f);
            } else {
                rb.velocity = new Vector2(speed, 0f);
                transform.parent.localScale = new Vector3(1f, 1f, 1f);
            }
        }   
    }
    void ResetAttack() {
        isAttacking = false;
    }
}