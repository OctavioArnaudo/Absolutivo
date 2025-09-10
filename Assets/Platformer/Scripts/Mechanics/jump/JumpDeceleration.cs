using UnityEngine;

public class JumpDeceleration : JumpSpeed
{
    [Tooltip("A global jump modifier applied to slow down an active jump when the user releases the jump input.")]
    [Range(1F, 9.81F)]
    public float jumpDeceleration = 1F;
}