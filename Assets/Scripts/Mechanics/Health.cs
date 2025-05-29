using System;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Represebts the current vital statistics of some game entity.
    /// </summary>
    public class Health : MonoBehaviour
    {
        /// <summary>
        /// The maximum hit points for the entity.
        /// </summary>
        [Header("Health Settings")]
        [SerializeField] private int maxHP = 100;
        private int currentHP;

        public int MaxHealth { get { return maxHP; } }
        public int CurrentHealth { get { return currentHP; } }

		/// <summary>
		/// Indicates if the entity should be considered 'alive'.
		/// </summary>
		private bool isAlive => currentHP > 0;
		public bool IsAlive { get { return isAlive; } }

		public event Action<int, int> OnHealthChanged;
        public event Action OnPlayerDied;

        void Awake() {
            currentHP = maxHP;
        }

        /// <summary>
        /// Increment the HP of the entity.
        /// </summary>
        public void Increment()
        {
            currentHP = Mathf.Clamp(currentHP + 1, 0, maxHP);
        }
        public void TakeHeal(int amount)
        {
            if(!isAlive) {
                return;
            }
            currentHP += amount;
            currentHP = Mathf.Min(currentHP, maxHP);
            OnHealthChanged?.Invoke(currentHP,maxHP);
        }

        /// <summary>
        /// Decrement the HP of the entity. Will trigger a HealthIsZero event when
        /// current HP reaches 0.
        /// </summary>
        public void Decrement()
        {
            currentHP = Mathf.Clamp(currentHP - 1, 0, maxHP);
            if (currentHP == currentHP - 1) {
                Debug.Log("a");
                var ev = Schedule<HealthIsDown>();
                ev.health = this;
            }
            if (currentHP == 0)
            {
                var ev = Schedule<HealthIsZero>();
                ev.health = this;
            }
        }
        public void TakeDamage(int amount)
        {
            if (!isAlive) { 
                return;
            }
            currentHP -= amount;
                currentHP = Mathf.Max(currentHP, 0);

                OnHealthChanged?.Invoke(currentHP, maxHP);

                if (!IsAlive) {
                    Die();
                }
	    }

        public void setHealth(int newHP)
        {
            currentHP = Mathf.Clamp(newHP, 0, maxHP);
            OnHealthChanged?.Invoke(currentHP, maxHP);
            if(!IsAlive) {
                Die();
            }
        }

        /// <summary>
        /// Decrement the HP of the entitiy until HP reaches 0.
        /// </summary>
        public void Die()
        {
            while (isAlive) Decrement();
            Debug.Log("Player has died");
            OnPlayerDied?.Invoke();
            Destroy(gameObject);
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Escape)) {
                TakeDamage(1);
            }
            if (Input.GetKeyDown(KeyCode.Escape)) {
                TakeHeal(1);
            }
            Debug.Log($"Playerhealth: {currentHP}");
        }

    }
}
