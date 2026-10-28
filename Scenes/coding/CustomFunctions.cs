using System.Runtime.Serialization;
using UnityEngine;

public class CustomFunctions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelUp();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // i can create custom functions right here
    //public ints show up in console to change number while testing
    public int xp = 100000;
    public int level = 1;
    void levelUp()
    {
        //when we lvl up, we increase our player level if the xp is high enough, then reduce xp
        //two varibles we really care about: XP and Level ( mabye: xp cap, stats, ect)
        if(xp >= 100)
        {
            //increase lvl and reset xp
            level = level + 1;
            //level==;
            //level+=1;
            xp = xp - 100;
            Debug.Log("Ding you lvl up");
        }
    }
}
