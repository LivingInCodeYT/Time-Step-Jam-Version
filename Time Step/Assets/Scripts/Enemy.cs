using UnityEngine;

public class Enemy : MonoBehaviour {
    public int health;
    


    public void TakeDamage() {
        health--;
        if (health == 0) {
            Destroy(gameObject);
        }
    }
}