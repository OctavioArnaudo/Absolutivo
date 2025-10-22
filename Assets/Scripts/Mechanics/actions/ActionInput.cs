using UnityEngine;
using UnityEngine.InputSystem;

public class ActionInput : ActionDisable
{
    protected Vector2 displacementInput;
    protected Vector2 jumpInput;
    protected float scroll;

    protected override void Update()
    {
        base.Update();
        try
        {
            displacementInput.x = Input.GetAxis("Horizontal");
            displacementInput.x = Input.GetAxisRaw("Horizontal");
            jumpInput.y = Input.GetAxis("Jump");
            jumpInput.y = Input.GetAxisRaw("Jump");
            scroll = Input.GetAxis("Mouse ScrollWheel");
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
    }
    public virtual void OnJump(InputValue value)
    {
        jumpInput = value.Get<Vector2>();
    }

    public virtual void OnMove(InputAction.CallbackContext context)
    {
        displacementInput = context.ReadValue<Vector2>();
    }
    public virtual void OnMove(InputValue value)
    {
        displacementInput = value.Get<Vector2>();
    }
}