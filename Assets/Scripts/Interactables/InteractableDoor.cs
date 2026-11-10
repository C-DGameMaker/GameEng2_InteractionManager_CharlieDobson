using UnityEngine;

public class InteractableDoor : MonoBehaviour, IInteractable
{
    public Vector3 normalPosition;

    public Vector3 openPosition;

    public GameObject door;

    public void Start()
    {
        normalPosition = transform.position;
    }
    public void Interact()
    {
        if(door.transform.position == normalPosition)
        {
            door.transform.position = openPosition;
        }
        else
        {
            door.transform.position = normalPosition;
        }

    }
}
