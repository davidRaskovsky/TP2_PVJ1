using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 7f; 
    public float rotationSpeed = 1f; 

    [Header("Jump Settings")]
    public float jumpForce = 6f; 
    public float groundCheckDistance = 1.1f; 
    public LayerMask groundLayer; 

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * -(speed / 6f) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -(rotationSpeed/speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * (rotationSpeed/speed) * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private bool IsGrounded()
    {
        bool hit = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);
        
        Color rayColor = hit ? Color.green : Color.red;
        Debug.DrawLine(transform.position, transform.position + Vector3.down * groundCheckDistance, rayColor);

        return hit;
    }
}
