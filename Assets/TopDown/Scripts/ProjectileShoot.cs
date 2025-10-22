using UnityEngine;

public class ProjectileShoot : MeleeAttack
{
    protected override void Start()
    {
        base.Start();
        OnObjectSpawned += ShootProjectile;
    }
    public void ShootProjectile(GameObject instance)
    {
        Vector3 direction = (instance.transform.position - transform.position).normalized;
        float speed = Random.Range(1f, spawnSpeed);

        Rigidbody rb = instance.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.transform.position = new Vector3(instance.transform.position.x + 1f * Time.deltaTime, instance.transform.position.y, instance.transform.position.z);
            rb.linearVelocity = direction * speed;
        }
    }
}