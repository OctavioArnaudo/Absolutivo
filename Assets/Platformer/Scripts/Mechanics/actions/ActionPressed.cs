using System;
using UnityEngine;

public class ActionPressed : ActionInput
{
    protected override void Update()
    {
        base.Update();
        try
        {
            jumpPressed = Input.GetKeyDown(KeyCode.Space);
            jumpPressed = Input.GetButtonDown("Jump");
            victoryPressed = Input.GetKeyDown(KeyCode.V);
            hurtPressed = Input.GetKeyDown(KeyCode.H);
            defeatPressed = Input.GetKeyDown(KeyCode.F);
            spawnPressed = Input.GetKeyDown(KeyCode.S);
        }
        catch (Exception)
        {
            jumpPressed = jumpAction.WasPressedThisFrame();
            victoryPressed = victoryAction.WasPressedThisFrame();
            hurtPressed = hurtAction.WasPressedThisFrame();
            defeatPressed = defeatAction.WasPressedThisFrame();
            spawnPressed = spawnAction.WasPressedThisFrame();
        }
    }
}