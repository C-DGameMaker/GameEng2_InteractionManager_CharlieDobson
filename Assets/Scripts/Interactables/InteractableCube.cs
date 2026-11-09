using UnityEngine;

public class InteractableCube : MonoBehaviour, IInteractable
{
    private Renderer _cubeRenderer;

    private void Awake()
    {
        _cubeRenderer = GetComponent<Renderer>();
    }
    public void Interact()
    {
        _cubeRenderer.material.color = Random.ColorHSV(0f, 1f, 0.5f, 1f);
    }
}
