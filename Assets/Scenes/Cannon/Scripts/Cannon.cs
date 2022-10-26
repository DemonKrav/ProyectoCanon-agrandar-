using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject bala;
    public Transform spawn;
    public float time = 1f;
    public float resetTime = 1f;

    public void Shoot()
    {
        Instantiate(bala, spawn.position, spawn.rotation);
    }


    public void Update()
    {
        temporizador();
    }


    public void temporizador()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
                Instantiate(bala, spawn.position, spawn.rotation);

                time = 1;
        }
    }

}