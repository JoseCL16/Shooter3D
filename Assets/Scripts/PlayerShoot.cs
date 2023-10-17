using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public Transform puntoDisparo;
    public float velocidadProyectil = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Disparar();
        }
    }

    void Disparar()
    {
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDisparo.position, puntoDisparo.rotation);
        Rigidbody rb = proyectil.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = puntoDisparo.forward * velocidadProyectil;
        }
    }
}