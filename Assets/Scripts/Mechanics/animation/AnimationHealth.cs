using UnityEngine;

public class AnimationHealth : MonoController
{
    /// <summary>
    /// Increment the HP of the entity.
    /// </summary>
    public void Increment()
    {
        // If the current HP is already at max, do nothing.
        currentHP = Mathf.Clamp(currentHP + 1, 0, maxHP);
    }

    /// <summary>
    /// Decrement the HP of the entity. Will trigger a HealthIsZero event when
    /// current HP reaches 0.
    /// </summary>
    public virtual void Decrement(int amount = 1)
    {
        // If the current HP is already at 0, do nothing.
        currentHP = Mathf.Clamp(currentHP - amount, 0, maxHP);

        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            int index = Mathf.Clamp(damageStates.Length - Mathf.FloatToHalf(currentHP), 0, damageStates.Length - 1);
            sr.sprite = damageStates[index];
        }
    }


    /// <summary>
    /// Decrement the HP of the entitiy until HP reaches 0.
    /// </summary>
    public void Die()
    {
        // If the current HP is already at 0, do nothing.
        while (isAlive) Decrement();
    }
}