using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerShoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject bullet;
    public float bulletSpeed = 15f;
    void OnAttack()
    {
        Debug.Log("PEW");
        //when i push the attack button, i want to spawn inn a bullet
        //i also want to pus the bullet in the direction of the mouse
        //i also want to destroy the bullet after a period of time so it doesn't live forever
        GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
        //find where the mouse is on the screen
        Vector3 mousePos = Mouse.current.position.ReadValue();
        //need to convert from pixel coordinates to world position in the game
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Debug.Log(mousePos);
        mousePos.z = 0;
        //destiontaion - starting position to calcutlate the vector from the player to the mouse
        Vector3 shootDir = mousePos - transform.position;
        shootDir.Normalize();
        //push the bullet in the direction calculated
        // old code
        //shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir;
        Destroy(shot, 10);
        Rigidbody2D rb = shot.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = shootDir * bulletSpeed;
        }
        //Challange:
        //make the bullets go faster but constatnt velocity
        //try to get enemy health
       // private void OnTriggerEnter2D(Collider2D collision)
    //{
        
    }
}

