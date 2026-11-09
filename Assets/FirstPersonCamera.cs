using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class FirstPersonCamera : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private Vector2 lookInput;
    private float xRotation = 0f;

    public float interactionRange = 5f;

    public Ray interactionLine;

    void Update()
    {
        xRotation -= lookInput.y * mouseSensitivity * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * lookInput.x * mouseSensitivity * Time.deltaTime);

        interactionLine = new Ray(transform.position, transform.forward);
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }
}
