using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 3;
    public Vector3 position;
    public float timeDestroy;

    public void Start()
    {
        Destroy(gameObject, timeDestroy);
    }


    public void Update()
    {
        {
            transform.position += position * speed * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += transform.localScale * 2;
        }
    }

}