using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShoot : MonoBehaviour
{
    public Transform bulletPoint;
    public GameObject playerBullet;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public virtual void Shoot()
    {
            Instantiate(playerBullet, bulletPoint.position, bulletPoint.rotation);
    }
}
