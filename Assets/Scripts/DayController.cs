using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayController : MonoBehaviour
{
    private int day = 0;
    private bool bed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bed)
        {
            if (Input.GetKeyDown("Y"))
            {
                day += 1;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        bed = true;
    }

    private void OnCollisionExit(Collision other)
    {
        bed = false;
    }
}
