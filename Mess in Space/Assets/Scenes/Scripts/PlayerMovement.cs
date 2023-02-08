using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float jumpForce = 3.0f;
    [SerializeField] private Rigidbody playerRigidbody;

    private Vector3 _movement;
    private Vector2 _cursorPosition;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.z = Input.GetAxisRaw("Vertical");
        _movement.y = Input.GetAxisRaw("Jump");
        
        _cursorPosition.x += Input.GetAxisRaw("Mouse X");
        _cursorPosition.y += Input.GetAxisRaw("Mouse Y");
        
    }

    private void FixedUpdate()
    {
        transform.Translate(_movement.normalized * Time.fixedDeltaTime * speed);                                                               //Movement 
        playerRigidbody.AddForce(playerRigidbody.velocity.x,_movement.y * Time.fixedDeltaTime * jumpForce, playerRigidbody.velocity.z);             //Jumping
        transform.localRotation = Quaternion.Euler(0, _cursorPosition.x, 0);                                                                   //Rotation

        //_rigidbody.MovePosition(_rigidbody.position +_movement.normalized * Time.fixedDeltaTime * speed);
        //_rigidbody.velocity = new Vector3(_xMovement, _rigidbody.velocity.y, _zMovement).normalized  * Time.deltaTime * speed;
    }
}