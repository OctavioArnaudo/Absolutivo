using UnityEngine;

public class MicroController : VictoryCollisions
{
    public float fallSpeed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        rb.gravityScale = 0f;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        Vector2 movement = new Vector2(displacementInput.x * maxMoveSpeed, -fallSpeed);
        rb.linearVelocity = movement;
    }
}