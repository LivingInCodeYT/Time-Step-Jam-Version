using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {
    public Animator anim;
    public int health = 2;

    public void Die() {
        anim.SetTrigger("Die");
        Invoke("RestartLevel", 1f);
    }
    public void RestartLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}