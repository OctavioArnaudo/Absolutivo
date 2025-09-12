using UnityEngine;

/// <summary>
/// A simple controller for enemies. Provides movement control over a patrol path.
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class EnemyController : MonoBehaviour
{
    /// <summary>
    /// 
    /// The PatrolPath defines the path that the enemy will follow.
    /// 
    /// </summary>
    public PatrolPath path;
    /// <summary>
    /// 
    /// The ouch sound is played when the enemy is hurt.
    /// 
    /// </summary>
    public AudioClip ouch;

    /// <summary>
    /// 
    /// The mover is used to control the enemy's movement along the patrol path.
    /// 
    /// </summary>
    internal PatrolPath.Mover mover;
    /// <summary>
    /// 
    /// The control is used to control the enemy's animation and movement.
    /// 
    /// </summary>
    internal AnimationController control;
    /// <summary>
    ///
    /// The collider is used to detect collisions with the enemy.
    /// 
    /// </summary>
    internal Collider2D collider2;
    /// <summary>
    /// 
    /// The audio source is used to play sounds related to the enemy.
    /// 
    /// </summary>
    internal AudioSource _audio;
    /// <summary>
    /// 
    /// The sprite renderer is used to render the enemy's sprite.
    /// 
    /// </summary>
    SpriteRenderer spriteRenderer;

    /// <summary>
    /// 
    /// The Bounds property returns the bounds of the enemy's collider.
    /// 
    /// </summary>
    public Bounds Bounds => collider2.bounds;

    void Awake()
    {
        // Ensure the control component is not null
        collider2 = GetComponent<Collider2D>();
        // Ensure the collider component is not null
        _audio = GetComponent<AudioSource>();
        // Ensure the audio source component is not null
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// 
    /// The OnCollisionEnter2D method is called when the enemy collides with another object.
    /// 
    /// It checks if the collided object is a player and schedules a PlayerEnemyCollision event.
    /// 
    /// </summary>
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object is a player
        var player = collision.gameObject.GetComponent<MonoController>();
        // If the collided object is not a player, return early
        if (player != null)
        {
            // If the collided object is a player, play the ouch sound if it exists
            var ev = Simulation.Schedule<PlayerEnemyCollision>();
            // Schedule a PlayerEnemyCollision event
            ev.player = player;
            // Set the player property of the event to the collided player
            ev.enemy = this;
        }
    }
}