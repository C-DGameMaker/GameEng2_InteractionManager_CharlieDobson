using UnityEngine;

public class InteractableDoor : MonoBehaviour, IInteractable
{
    public Vector3 normalPosition;

    public Vector3 openPosition;

    public void Start()
    {
        normalPosition = transform.position;
    }
    public void Interact()
    {
        if(transform.position == normalPosition)
        {
            transform.position = openPosition;
        }
        else
        {
            transform.position = normalPosition;
        }

    }
}
