using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EHomingShoot : EnemyShoot
{ 

    void Update()
    {
        canonShoot += Time.deltaTime;
        Eshoot();
    }

    public override void Eshoot()
    {
        if (canonShoot >= reload)
        {
            Instantiate(enemyBullet, EBulletPoint.position, Quaternion.identity);
            canonShoot = 0;
        }
    }
}