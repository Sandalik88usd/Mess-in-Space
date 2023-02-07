using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    private Rigidbody _rigidbody;
    private Vector3 _movement;

    // Update is called once per frame
    void Update()
    {
        _movement.z = Input.GetAxis("Horizontal");
        _movement.x = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _movement * Time.deltaTime * _speed;
    }
}
