using Unity.VisualScripting;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public FirstPersonCamera playerCamera;

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

    public void RaycastHit()
    {
        if(Physics.Raycast(playerCamera.interactionLine, out RaycastHit hit, playerCamera.interactionRange))
        {
            Debug.Log("Looking at " + hit.collider.name);
        }

    }
}
