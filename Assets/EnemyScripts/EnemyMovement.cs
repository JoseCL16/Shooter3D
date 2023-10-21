using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float sway;
    public float timer;


    void Awake ()
    {
        timer = 0;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Sway();
    }

    public virtual void Move()
    {
        rb.velocity = new Vector3(speed, rb.velocity.y, 0);
    }

    public virtual void Sway()
    {
        timer += Time.deltaTime;
        if (timer >= sway)
        {
            speed *= -1;
            timer = 0;
        }
    }
}
