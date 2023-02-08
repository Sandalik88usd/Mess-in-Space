using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 _cursorPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position =  playerTransform.position;
        
        _cursorPosition.x += Input.GetAxisRaw("Mouse X");
        _cursorPosition.y += Input.GetAxisRaw("Mouse Y");
        transform.localRotation = Quaternion.Euler(-_cursorPosition.y, _cursorPosition.x, 0);
    }
}
