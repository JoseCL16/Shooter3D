using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot1 : MonoBehaviour
{
    public GameObject proyectilPrefab;  // Debes asignar un prefab de proyectil en el Inspector.
    public Transform puntoDeDisparo;   // El punto desde donde se dispararán los proyectiles.
    public float intervaloDeDisparo = 0.3f;  // Intervalo de disparo en segundos.
    private float tiempoUltimoDisparo;
    public float velocidadProyectil = 10f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time - tiempoUltimoDisparo >= intervaloDeDisparo)
        {
            Disparar();
            tiempoUltimoDisparo = Time.time;
        }
    }

    void Disparar()
    {
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDeDisparo.position, puntoDeDisparo.rotation);
        Rigidbody rb = proyectil.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = puntoDeDisparo.forward * velocidadProyectil;
        }
    }
}