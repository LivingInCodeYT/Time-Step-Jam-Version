using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    Rigidbody2D rb;
    Animator anim;

    private float hMove;
    private bool isGrounded;

    public float moveSpeed = 5;
    public float jumpForce = 1;
    public Transform groundCheck;
    public float checkRad;
    public LayerMask whatIsGround;
    

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update() {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRad, whatIsGround);
        hMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        if (hMove < 0) {
            GetComponent<SpriteRenderer>().flipX = true;
        } else if (hMove > 0) {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) {
            Jump();
        }
        rb.velocity = new Vector2(hMove, rb.velocity.y);

    }
    void Jump() {
        if (isGrounded) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}