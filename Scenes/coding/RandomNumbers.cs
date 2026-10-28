using UnityEngine;

public class RandomNumbers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // declared variable
        int r = 0;
        //random.range is inclusive on on the min,
        //exclusive on the max. so (1, 100) can give values from 1-99
        r = Random.Range(1, 100);
        Debug.Log(r);
        //floats using Random.Range are inclusive on the min and max
        //so (1f, 100f) can give any vaule from 1.0-100.0
        float rand = Random.Range(1f, 100f);
        Debug.Log(rand);
        if(rand > 0.50)
        {
            Debug.Log("Special loot drop");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
