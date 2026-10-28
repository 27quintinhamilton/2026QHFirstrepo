using UnityEngine;

public class Lootpool : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //the main class variable
    private int attack = 50;
    private int ral;
    private bool FoughtEnemy = false;
    // Update is called once per frame
    void Start()
    {
        // the random variables r=attack ral=random loot


        int r = Random.Range(1, 101);
        ral = Random.Range(1, 101);
        //updates the attack varible to a 50% chance
        attack = r + 50;

    }
    void Update()
    {
        //the if statment above 100 
        // also to make sure to not to loop in update
        if (!FoughtEnemy && attack >= 100)
        {
            // since it is in update there needed to be cap
            // I wrote this code not realising this
            FoughtEnemy = true;
            Debug.Log("you defeated the enemy");
            //don't fully understand && but it got it to work
            //the Else if statements are to speed things up
            if (ral >= 1 && ral <= 39)
            {
                Debug.Log("you get no loot");
            }
            else if (ral >= 40 && ral <= 69)
            {
                Debug.Log("you get normal item");
            }
            else if (ral >= 70 && ral <= 89)
            {
                Debug.Log("you get rare item");
            }
            else if (ral >= 90 && ral <= 100)
            {
                Debug.Log("you get legendary item");
            }
        }
    }
}