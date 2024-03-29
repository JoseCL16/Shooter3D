using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;

    private Vector3 direction;

    public Vector3 Direction
    {
        get
        {
            return direction;
        }
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        direction = Vector3.forward;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0 || vertical != 0)
        {
            direction = new Vector3(horizontal, 0, vertical);
        }

        if(direction.magnitude >=0f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
        }


        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
    }
}


