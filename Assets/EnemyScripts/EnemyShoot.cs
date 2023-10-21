using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform EBulletPoint;
    public GameObject enemyBullet;
    public float canonShoot;
    public float reload = 5f;


    private void Update()
    {
        canonShoot += Time.deltaTime;
        if (canonShoot >= reload)
        {
            Eshoot();
            canonShoot = 0;
        }
    }

    public virtual void Eshoot()
    {
        Instantiate(enemyBullet, EBulletPoint.position, EBulletPoint.rotation);
    }
}