using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float sensitivityX = 8f;
    [SerializeField] private float sensitivityY = 0.5f;

    [SerializeField] private Transform playerCamera;
    [SerializeField] private float xClamp = 85f;
    private float mouseX, mouseY;
    private float xRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, mouseX * Time.deltaTime);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -xClamp, xClamp);
        var targetRotation = transform.eulerAngles;
        targetRotation.x = xRotation;
        playerCamera.eulerAngles = targetRotation;
    }

    public void ReceiveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensitivityX;
        mouseY = mouseInput.y * sensitivityY;
    }
}