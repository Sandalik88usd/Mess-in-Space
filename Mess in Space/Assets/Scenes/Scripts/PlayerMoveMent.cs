using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float jumpForce = 3.0f;
    public Rigidbody _rigidbody;
    private Vector3 _movement;
    private Vector2 _cursorInput;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.z = Input.GetAxisRaw("Vertical");
        _movement.y = Input.GetAxisRaw("Jump");
        _cursorInput.x += Input.GetAxisRaw("Mouse X");
        _cursorInput.y += Input.GetAxisRaw("Mouse Y");
        
    }

    private void FixedUpdate()
    {
        transform.Translate(_movement.normalized * Time.fixedDeltaTime * speed);
        _rigidbody.AddForce(_rigidbody.velocity.x,_movement.y * Time.fixedDeltaTime * jumpForce, _rigidbody.velocity.z);
        //_rigidbody.MovePosition(_rigidbody.position +_movement.normalized * Time.fixedDeltaTime * speed);
        transform.localRotation = Quaternion.Euler(0, _cursorInput.x, 0);
        //_rigidbody.velocity = new Vector3(_xMovement, _rigidbody.velocity.y, _zMovement).normalized  * Time.deltaTime * speed;
    }
}