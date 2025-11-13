using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    public float carbonValue = 300; // example
    public float forceRequired = 0.5f; // will scale with carbon

    private float accumulatedForce = 0f;

    void Start()
    {
        // map carbon to force requirement
        forceRequired = Mathf.Lerp(0.1f, 3f, carbonValue / 1200f);
    }

    public void ApplyForce(float amount)
    {
        accumulatedForce += amount;

        if (accumulatedForce >= forceRequired)
        {
            gameObject.SetActive(false); // “breaks” the wall
        }
    }
    
}


