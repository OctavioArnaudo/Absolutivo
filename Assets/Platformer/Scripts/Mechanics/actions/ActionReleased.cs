using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionReleased : ActionPressed
{
    protected override void Update()
    {
        base.Update();
        try
        {
            jumpReleased = Input.GetButtonUp("Jump");
        }
        catch (Exception)
        {
            jumpReleased = jumpAction.WasReleasedThisFrame();
        }
    }
    public override void OnJump(InputAction.CallbackContext context)
    {
        base.OnJump(context);
        if (context.phase == InputActionPhase.Started)
        {
            jumpPressed = true;
            jumpReleased = false;
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            jumpPressed = false;
            jumpReleased = true;
        }
    }
}