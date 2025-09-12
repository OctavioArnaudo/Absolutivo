using UnityEngine;
using UnityEngine.InputSystem;

public class ActionInput : ActionDisable
{
    protected Vector2 displacementInput;
    protected Vector2 jumpInput;

    protected override void Update()
    {
        base.Update();
        try
        {
            displacementInput.x = Input.GetAxis("Horizontal");
            displacementInput.x = Input.GetAxisRaw("Horizontal");
            jumpInput.y = Input.GetAxis("Jump");
            jumpInput.y = Input.GetAxisRaw("Jump");
        }
        catch (System.Exception)
        {
            displacementInput = displacementAction.ReadValue<Vector2>();
            jumpInput.y = displacementInput.y;
        }
    }
    public virtual void OnJump(InputAction.CallbackContext context)
    {
        jumpInput = context.ReadValue<Vector2>();
        justLanded = context.phase == InputActionPhase.Canceled;
    }
    public virtual void OnMove(InputAction.CallbackContext context)
    {
        displacementInput = context.ReadValue<Vector2>();
    }
}