using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 7.0f;
    private Vector3 _traectory = new Vector3(15, 0,0 );
    public void Destroy() => Destroy(gameObject);

    private void FixedUpdate()
    {
        if (transform.position.x > _traectory.x)
        {
            transform.position = new Vector3(15, transform.position.y, 0);
            transform.Translate(-_traectory * Time.fixedDeltaTime * speed);
        }
        if (transform.position.x < -_traectory.x)
        {
            transform.position = new Vector3(-15, transform.position.y, 0);
            transform.Translate(_traectory * Time.fixedDeltaTime * speed);
        }

    }
}
