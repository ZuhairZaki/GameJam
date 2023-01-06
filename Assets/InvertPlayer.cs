using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2d controller;
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController2d>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            controller.Invert();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            controller.Invert();
        }
    }

}
