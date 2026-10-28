using UnityEngine;
using UnityEngine.InputSystem;
public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //first check for user input to see if we should move
        //user input in topdown: checks vertical and horizontal input
        //w, s should move the player up/down
        //a, d should move the player side to side
        //Debug.Log(moveX); this is bugged code fix later
        //if we have user input, move the player based on that imput

    }

    public void OnMove(InputValue value)
    {
        //vector 2 is a special variable that stores x, y as floats
        //Debug.Log(value.Get<Vector2>());
        //we need to use this vector2 to make the play move
        //we multiply the imput by a speed variBLE TO MAKE US GO FASTER
        //THE speed variable depends on the type of game your making
        GetComponent<Rigidbody2D>().linearVelocity = value.Get<Vector2>() * moveSpeed;
    }
}
