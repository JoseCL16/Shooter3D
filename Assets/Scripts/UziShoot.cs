using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UziShoot : WeaponShoot 
{
    public float fireRate = 0.3f;
    public float maxFireRate;

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time - maxFireRate >= fireRate)
        {
            Shoot();
        }
    }

    public override void Shoot()
    { 
        maxFireRate = Time.time;
        Instantiate(playerBullet, bulletPoint.position, bulletPoint.rotation);
    }
}