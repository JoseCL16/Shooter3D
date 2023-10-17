using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{

    public int slot= 0;


    void Start()
    {
        GetWeapon();
    }

    void Update()
    {
        int prevSlot = slot;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (slot >= transform.childCount - 1)
                slot = 0;
            else
                slot++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (slot <= 0)
                slot = transform.childCount -1;
            else
                slot--;
        }

        if (prevSlot != slot)
        {
            GetWeapon();
        }
    }

    void GetWeapon()
    {
        int i = 0;

        foreach (Transform weapon in transform)
        {
            if (i == slot)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
