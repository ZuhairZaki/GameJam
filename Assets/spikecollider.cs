using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spikecollider : MonoBehaviour
{
    // Start is called before the first frame update
    public HealthBar hb;
    public Animator animator;
    void Start()
    {
        hb = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBar>();
        animator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hb.Die();
            animator.SetBool("IsDead", true);
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
