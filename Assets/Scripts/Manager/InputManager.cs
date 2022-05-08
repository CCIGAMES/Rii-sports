using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Movement movement;
    [SerializeField] private MouseLook mouseLook;
    private Controls.PlayerActions actions;
    private Controls controls;
    private Vector2 horizontalInput;
    private Vector2 mouseInput;

    private void Awake()
    {
        controls = new Controls();
        actions = controls.Player;

        actions.Move.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
        actions.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        actions.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
    }

    private void Update()
    {
        movement.ReceiveInput(horizontalInput);
        mouseLook.ReceiveInput(mouseInput);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDestroy()
    {
        controls.Disable();
    }
}