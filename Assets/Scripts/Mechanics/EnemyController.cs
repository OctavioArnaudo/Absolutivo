using System;
using UnityEngine;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
	/// <summary>
	/// A simple controller for enemies. Provides movement control over a patrol path.
	/// </summary>
	[RequireComponent(typeof(AnimationController), typeof(Collider2D))]
	public class EnemyController : MonoBehaviour
	{
		public PatrolPath path;
		public AudioClip ouch;

		internal PatrolPath.Mover mover;
		internal AnimationController control;
		internal Collider2D _collider;
		internal AudioSource _audio;
		SpriteRenderer spriteRenderer;
		internal Animator animator;

		/// <summary>
		/// Evento que se dispara cuando el enemigo colisiona con el jugador.
		/// </summary>
		public event Action<PlayerController, EnemyController> OnPlayerCollision;

		public Bounds Bounds => _collider.bounds;

		void Awake()
		{
			control = GetComponent<AnimationController>();
			_collider = GetComponent<Collider2D>();
			_audio = GetComponent<AudioSource>();
			spriteRenderer = GetComponent<SpriteRenderer>();
			animator = GetComponent<Animator>();

			if (path != null)
			{
				mover = path.CreateMover(control.maxSpeed * 0.5f);
			}
		}

		void OnCollisionEnter2D(Collision2D collision)
		{
			var player = collision.gameObject.GetComponent<PlayerController>();
			if (player != null)
			{
				var ev = Schedule<PlayerEnemyCollision>();
				ev.player = player;
				ev.enemy = this;

				OnPlayerCollision?.Invoke(player, this);
			}
		}

		void Update()
		{
			if (path != null)
			{
				if (mover == null)
					mover = path.CreateMover(control.maxSpeed * 0.5f);
				control.move.x = Mathf.Clamp(mover.Position.x - transform.position.x, -1, 1);
			}

			if (mover != null)
			{
				float moveDirection = Mathf.Clamp(mover.Position.x - transform.position.x, -1, 1);
				control.move.x = moveDirection;
				// Actualiza la animación de movimiento si el Animator está presente
				if (animator != null)
				{
					//animator.SetFloat("Speed", Mathf.Abs(moveDirection));
				}
			}
		}

	}
}
