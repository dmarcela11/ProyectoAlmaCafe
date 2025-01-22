using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRenderer : MonoBehaviour
{
    [Header("Dependencies")]
    public SpriteRenderer spriteRenderer;

    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 movement = value.ReadValue<Vector2>();

        if (movement.x > 0f && PlayerIsLookingLeft()) //Movimiento a la derecha
        {
            spriteRenderer.flipX = false;
        }
        else if (movement.x < 0f && !PlayerIsLookingLeft()) //Movimiento a la izquierda
        {
            spriteRenderer.flipX = true;
        }
    }

    private bool PlayerIsLookingLeft()
    {
        return spriteRenderer.flipX;
    }
    
}
