using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class EmitParticlesOnLand : MonoBehaviour
{

    public bool emitOnEnemyDeath = true;

#if UNITY_TEMPLATE_PLATFORMER

    ParticleSystem p;

    void Start()
    {
        p = GetComponent<ParticleSystem>();

        if (emitOnEnemyDeath) {
        }

    }

#endif

}
