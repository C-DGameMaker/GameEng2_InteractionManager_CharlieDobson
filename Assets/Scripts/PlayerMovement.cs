using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Player Movement Variables")]

    [SerializeField] Rigidbody playerRB;
    [SerializeField] float playerSpeed;
    [SerializeField] Vector2 movementInput;

    [Header("Player Interaction Variables")]
    public bool canMove;

    void Start()
    {
        if (playerRB == null)
        {
            playerRB = GetComponent<Rigidbody>();
        }

        canMove = true;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void Update()
    {
        HandlePlayerMovement();
    }

    private void HandlePlayerMovement()
    {
        if (canMove == false) return;
        Vector3 move = transform.right * movementInput.x + transform.forward * movementInput.y;

        move *= playerSpeed * Time.deltaTime;

        playerRB.MovePosition(playerRB.position + move);
    }

}