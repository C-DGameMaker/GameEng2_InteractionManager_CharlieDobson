using TMPro;
using UnityEngine;

public class InteractableButton : MonoBehaviour, IInteractable
{
    public int buttonPressed;

    public TextMeshProUGUI textToChange;
    public void Interact()
    {
        buttonPressed++;

        textToChange.text = "You pressed the button: " + buttonPressed + " times";
    }
}
