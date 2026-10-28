using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ConditionalStatements : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int score = 0;
    void Start()
    {
        //starting varible
        score = 0;

    }
    // Update is called once per frame
    void Update()
    {
        //the if statment above 100
        if (score <= 100)
        {
            // statement for getting above 100
            Debug.Log("New Reward Unlocked");
        }
        //the if statment below 100
        if (score >= 100)
        {
            //statment for below 100
            Debug.Log("Keep Trying");
        }
    }
}