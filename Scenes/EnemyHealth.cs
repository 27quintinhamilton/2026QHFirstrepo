using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health = 2;
    //if enemy hit by a bullet reduce, its health
    //iff enemy health gets to low they die

    //this function doesnt run if collider is set to trigger
    public GameObject healthPack;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        // if enemy hits a bullet
        if(collision.gameObject.tag == "bullet")
        {
            Debug.Log("ow");
            health -= 10;
            //if enemy health gets to low destroy them
            if(health <= 0)
            {
                int r = Random.Range(1, 11);
                if (r >= 5)
                Destroy(gameObject);
                Instantiate(healthPack, transform.position, Quaternion.identity);
            }
        }
    }
  // challange making enemy drops health packs
  //new script hits anything whose != (this means not equal) player
}
