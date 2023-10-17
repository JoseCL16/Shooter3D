using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public Rigidbody rb;
    public float MBT;
    public float TBT;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        TBT += Time.deltaTime;

        if (TBT >= MBT)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}