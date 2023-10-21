using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int Plife = 10;


    void Update()
    {
      if (Plife <=0)
      {
            SceneManager.LoadScene("Defeat");
            Destroy(gameObject);
      }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Plife -= 1;
        }

        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            Plife -= 1;
        }
    }
}
