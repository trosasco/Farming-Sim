using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtController : MonoBehaviour
{
    private bool activated = false;
    public GameObject plant;
    public GameObject tilledDirt;
    private PlayerScript.Tool equiped;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                if (tilledDirt.activeSelf)
                {
                    //Activates Plant if dirt is tilled.
                    if (!plant.activeSelf)
                    {
                        plant.SetActive(true);   
                    }
                    else
                    {
                        //Water
                    }
                }
                else
                {
                    //Tills the dirt
                    if (equiped == PlayerScript.Tool.Hoe)
                    {
                        tilledDirt.SetActive(true);
                    }
                }
            }
        }
    }

    //If player is touching
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Player"))
        {
            activated = true;
            equiped = other.gameObject.GetComponent<PlayerScript>().equiped;
        }
    }

    //If player stopped touching
    private void OnCollisionExit(Collision other)
    {
        if (other.transform.CompareTag("Player"))
        {
            activated = false;
        }
    }
}
