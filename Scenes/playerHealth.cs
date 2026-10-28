using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public int health = 70;

    //when the player hits an enemy
    //reduce the player health
    //then, if health is too low, you die, aka reload the level
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("I hit an enemy!");
            health -= 20;
            if (health <= 0)
            {
                Debug.Log("You died!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            {
                if (collision.gameObject.tag == "healthpack")
                    health += 20;
            }
        }
    }
}
