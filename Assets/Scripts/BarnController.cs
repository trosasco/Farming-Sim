using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarnController : MonoBehaviour
{
    public GameObject model;
    private bool activated = false;
    public PlayerScript.Tool type;
    public PlayerScript ps;
    
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
                if (model.activeSelf)
                {
                    if (ps.equiped == PlayerScript.Tool.Hands)
                    {
                        model.SetActive(false);
                        ps.equiped = type;
                    }
                }
                else
                {
                    if (ps.equiped == type)
                    {
                        model.SetActive(true);
                        ps.equiped = PlayerScript.Tool.Hands;
                    }
                }
            }
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activated = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activated = false;
        }
    }
}
