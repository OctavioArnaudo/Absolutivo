using UnityEngine;

public class JumpSpeed : DisplacementFacing
{
    [Header("Jump Impulse Settings")]
    [Tooltip("The speed at which the character jumps off the ground.")]
    [Range(2F, 6F)]
    protected float maxJumpSpeed = 6F;
}