using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{

    public int slot= 0;
    [SerializeField]
    private Transform weapon;

    void Start()
    {
        GetWeapon();
    }

    void Update()
    {
        
    }

    void GetWeapon()
    {
        int i = 0;

        foreach (Transform weapon in weapon)
        {
            if (i == slot)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        
        Debug.Log($"Collider:{ collision.gameObject.name}");
        int prevSlot = slot;

        if (collision.gameObject.CompareTag("Pistol"))
        {
            slot = 0;
            if (prevSlot != slot)
            {
                GetWeapon();
            }
        }

        if (collision.gameObject.CompareTag("Shotgun"))
        {
            slot = 1;
            if (prevSlot != slot)
            {
                GetWeapon();
            }
        }

        if (collision.gameObject.CompareTag("Uzi"))
        {
            slot = 2;
            if (prevSlot != slot)
            {
                GetWeapon();
            }
        }
    }
}