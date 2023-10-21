using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Rigidbody rb2;
    public float MBT2;
    public float TBT2;
    public float speed2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
        rb2.velocity = transform.forward * speed2;
    }

    void Update()
    {
        TBT2 += Time.deltaTime;

        if (TBT2 >= MBT2)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(gameObject);
        }
    }
}
