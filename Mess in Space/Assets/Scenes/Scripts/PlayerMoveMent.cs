using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    public Rigidbody _rigidbody;
    private Vector3 _movement;
    private Vector2 _cursorInput;
    

    // Update is called once per frame
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.z = Input.GetAxisRaw("Vertical");
        _cursorInput.x += Input.GetAxisRaw("Mouse X");
        _cursorInput.y += Input.GetAxisRaw("Mouse Y");
    }

    private void FixedUpdate()
    {
        transform.Translate(transform.position + _movement.normalized * Time.fixedDeltaTime * speed);
        transform.localRotation = Quaternion.Euler(0, _cursorInput.x, 0);
    }
}