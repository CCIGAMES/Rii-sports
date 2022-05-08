using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 11f;
    [SerializeField] private float gravity = -30f;
    [SerializeField] private LayerMask groundMask;
    private Vector2 move;
    private bool isGrounded;
    private bool jump;
    private Vector3 verticalVelocity = Vector3.zero;

    private void Update()
    {
        var transform1 = transform;
        var horizontalVelocity = (transform1.right * move.x + transform1.forward * move.y) * speed;

        isGrounded = Physics.CheckSphere(transform1.position, 0.1f, groundMask);
        if (isGrounded) verticalVelocity.y = 0;
        
        controller.Move(horizontalVelocity * Time.deltaTime);
        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }

    public void ReceiveInput(Vector2 _horizontalInput)
    {
        move = _horizontalInput;
    }
}