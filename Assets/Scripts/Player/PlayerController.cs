using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [Header("Configuration")]
    public float speed;
    
    [Header("Dependencies")]
    public Rigidbody2D rb;
    
    //Privates
    private Vector2 _movementInput;

    private void FixedUpdate()
    {
        rb.velocity = _movementInput * speed;
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        _movementInput = value.ReadValue<Vector2>();
    }
    
}
