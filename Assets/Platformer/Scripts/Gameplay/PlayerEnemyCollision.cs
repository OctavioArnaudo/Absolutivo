/// <summary>
/// Fired when a Player collides with an Enemy.
/// </summary>
/// <typeparam name="EnemyCollision"></typeparam>
public class PlayerEnemyCollision : Simulation.Event<PlayerEnemyCollision>
{
    public EnemyController enemy;
    public MonoController player;

    public override void Execute()
    {
        var willHurtEnemy = player.GetComponent<UnityEngine.Collider>().bounds.center.y >= enemy.Bounds.max.y;

        if (willHurtEnemy)
        {
            var enemyHealth = enemy.GetComponent<HealthModel>();
            if (enemyHealth != null)
            {
                enemyHealth.Decrement();
                Simulation.Schedule<EnemyDeath>().enemy = enemy;
            }
            else
            {
                Simulation.Schedule<EnemyDeath>().enemy = enemy;
            }
        }
        else
        {
            Simulation.Schedule<PlayerDeath>();
        }
    }
}