using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionManager : MonoBehaviour
{
    public FirstPersonCamera playerCamera;
    public RaycastHit hitLine;

    private void Start()
    {
        if(playerCamera == null)
        {
            Debug.Log("Camera is empty");
        }

        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Update()
    {
        RaycastHit();
    }

    public void Interact(InputAction.CallbackContext context)
    {
            Debug.Log("Got here");
            if(hitLine.collider.TryGetComponent(out IInteractable interactable))
            {
                interactable.Interact();
            }
            else
            {
                Debug.Log("Can't interact");
                return;
            }
        
    }

    public void RaycastHit()
    {
        if(Physics.Raycast(playerCamera.interactionLine, out RaycastHit hit, playerCamera.interactionRange))
        {
            hitLine = hit;
        }

    }
}
