using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Movement : EnemyMovement
{
    void Update()
    {
        Move();
        Sway();
    }
    
    public override void Move()
    {
        Vector3 newDir = transform.forward;
        transform.Translate(newDir * speed * Time.deltaTime);
    }

    public override void Sway()
    {
        timer += Time.deltaTime;
        if (timer >= sway)
        {
            float angle = Random.Range(0f, 360f);
            transform.rotation = Quaternion.Euler(0, angle, 0);
            timer = 0;
        }
    }
}