using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EHomingBullet : MonoBehaviour
{
    private Transform ptarget;
    private Vector3 target;

    public Rigidbody rb3;

    public float MBT3;
    public float TBT3;
    public float speed3;

    void Start()
    {
        rb3 = GetComponent<Rigidbody>();

        ptarget = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector3(ptarget.position.x, 1.5f, ptarget.position.z);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed3 * Time.deltaTime);

        TBT3 += Time.deltaTime;

        if (TBT3 >= MBT3)
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
