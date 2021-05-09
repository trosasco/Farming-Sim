using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public CharacterController controller;
    public enum Tool {Hands, Hoe, Shovel, WaterCan, Scythe};

    public Tool equiped = Tool.Hands;

    public GameObject Hands;
    public GameObject Hoe;
    public GameObject WaterCan;

    public float speed = 4f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, 0f, vertical).normalized;

        if (dir.magnitude >= 0.1f)
        {
            //controller.Move(dir * speed * Time.deltaTime);
            rb.velocity = (dir * speed);
        }

        updateTools();
    }

    void updateTools()
    {
        Hands.SetActive(equiped == Tool.Hands);
        Hoe.SetActive(equiped == Tool.Hoe);
        WaterCan.SetActive(equiped == Tool.WaterCan);
    }
}
