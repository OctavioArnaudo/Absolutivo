using UnityEngine;

public class DisplacementTeleport : DisplacementImpulse
{
    public void Teleport(Vector3 position)
    {
        rb.position = position;
        rb.linearVelocity *= 0;
    }
}