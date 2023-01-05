using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public CharacterController2d controller;
    public float speed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    public HealthBar hb;
    float health = 100f;
    // Start is called before the first frame update
    void Start()
    {
        hb = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBar>();
        hb.SetMaxHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            health -= 10;
            hb.SetHealth(health);
            
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
