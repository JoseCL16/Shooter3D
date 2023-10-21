using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EViewShoot : EnemyShoot
{

    private void Update()
    {
        canonShoot += Time.deltaTime;
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player") && canonShoot >= reload)
        {
            Eshoot();
            canonShoot = 0;
        }
    }

    public override void Eshoot()
    {
        base.Eshoot();
    }
}
