using UnityEngine;

public class DisplacementAcceleration : DisplacementSpeed
{
    [Range(2F, 15F)]
    public float moveAcceleration = 15F;
}