using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Gameplay
{

	/// <summary>
	/// Fired when a Player collides with an Enemy.
	/// </summary>
	/// <typeparam name="EnemyCollision"></typeparam>
	public class PlayerEnemyCollision : Simulation.Event<PlayerEnemyCollision>
	{
		public EnemyController enemy;
		public PlayerController player;

		PlatformerModel model = Simulation.GetModel<PlatformerModel>();

		public override void Execute()
		{
			var willHurtEnemy = player.Bounds.center.y >= enemy.Bounds.max.y;

			Debug.Log("Prota pisa a Enemigo?");

			if (willHurtEnemy)
			{
				Debug.Log("Prota SI pisa a Enemigo");
				var enemyHealth = enemy.GetComponent<Health>();
				if (enemyHealth != null)
				{
					Debug.Log("Enemigo tiene Vida");
					enemyHealth.Decrement();
					Debug.Log("Enemigo pierde Vida");
					if (!enemyHealth.IsAlive)
					{
						Debug.Log("Si Enemigo muere, ");
						Schedule<EnemyDeath>().enemy = enemy;
						Debug.Log("Prota salta por 2");
						player.Bounce(2);
					}
					else
					{
						Debug.Log("Si Enemigo NO muere, ");
						Debug.Log("Prota salta normal");
						player.Bounce(7);
					}
				}
				else
				{
					Debug.Log("Si Enemigo muere, ");
					Schedule<EnemyDeath>().enemy = enemy;
					Debug.Log("Prota salta por 2");
					player.Bounce(2);
				}
			}
			else
			{
				Debug.Log("Prota entra en contacto con Enemigo");
				Debug.Log("cualquiera sea donde no lo pise");
				Debug.Log("Prota empieza a morir");
				Schedule<PlayerDying>();
				//Schedule<PlayerDeath>();
			}

			willHurtEnemy = player.Bounds.center.y <= enemy.Bounds.min.y;

			Debug.Log("Enemigo pisa a Prota?");

			if (willHurtEnemy)
			{
				Debug.Log("Enemigo SI pisa a Prota");
				var enemyHealth = enemy.GetComponent<Health>();
				if (enemyHealth != null)
				{
					Debug.Log("Enemigo tiene Vida");
					enemyHealth.Increment();
					Debug.Log("Enemigo gana Vida");
					if (!enemyHealth.IsAlive)
					{
						Debug.Log("Enemigo salta por 2");
						player.Bounce(2);
						Debug.Log("antes que Enemigo muere");
						Schedule<EnemyDeath>().enemy = enemy;
					}
					else
					{
						Debug.Log("Si Enemigo NO muere, ");
						Debug.Log("Prota salta normal");
						player.Bounce(7);
					}
				}
				else
				{
					Debug.Log("Si Enemigo muere, ");
					Schedule<EnemyDeath>().enemy = enemy;
					Debug.Log("Prota salta por 2");
					player.Bounce(2);
				}
			}
			else
			{
				Debug.Log("Prota entra en contacto con Enemigo");
				Debug.Log("cualquiera sea donde no lo pise");
				Debug.Log("Prota a Enemigo o Enemigo a Prota");
				Debug.Log("Prota empieza a morir");
				Schedule<PlayerDying>();
				//Schedule<PlayerDeath>();
			}
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision.gameObject.CompareTag("Enemy"))
			{
				PlayerHealth playerHealth = GetComponent<PlayerHealth>();
				if (playerHealth != null)
				{
					playerHealth.TakeDamage(10); // Resta 10 de vida
				}
			}
		}


	}
}

