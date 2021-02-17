using UnityEngine;

public class Laser : MonoBehaviour {
    public LineRenderer lRend;
    public float laserRange;
    public LayerMask laserHits;

    void Update() {
        lRend.SetPosition(0, transform.position);
        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, transform.up, laserRange, laserHits);
        if (hit2D.collider != null) {
            lRend.SetPosition(1, hit2D.transform.position);
            if (hit2D.collider.gameObject.tag == "Player") {
                Debug.Log("Player hit with " + gameObject);
                hit2D.collider.gameObject.GetComponent<PlayerDeath>().Die();
            } else if (hit2D.collider.gameObject.tag == "Enemy") {
                hit2D.collider.transform.parent.gameObject.GetComponent<Enemy>().TakeDamage();
            }
        }
    
    }



}