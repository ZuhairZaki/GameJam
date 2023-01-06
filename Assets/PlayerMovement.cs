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
    float maxHealth = 100f;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        hb = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBar>();
        hb.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
