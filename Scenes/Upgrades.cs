using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public int coins = 100;
    public int swordlevel = 1;
    public int price = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpgradeSword();
    }
    void UpgradeSword()
    {
        //checks to see if you have more coins the price of the upgrade
        if (coins >= price)
        {
            coins = coins - price;
            // takes the coins away for the upsgrade
            swordlevel++;
            //lvl up shortcut
            price = 50;
            //changes price
            Debug.Log("sword lvl up");
            //tells the consle of the lvl up
        }
        else
            Debug.Log("you dont have enough coins");
        
    }

}
