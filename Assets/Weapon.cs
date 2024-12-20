using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource shootSound;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        shootSound.Play();
     Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
