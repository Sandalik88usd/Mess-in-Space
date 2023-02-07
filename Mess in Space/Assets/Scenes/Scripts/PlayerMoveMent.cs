using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;
using UnityEngine.Quaternion;

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
        _cursorInput.x = Input.GetAxisRaw("Mouse X");
        _cursorInput.y = Input.GetAxisRaw("Mouse Y");
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement.normalized * Time.fixedDeltaTime * speed);
        Debug.Log(_cursorInput);
        transform.rotation = new Quaternion( _cursorInput * Time.fixedDeltaTime);
    }
}