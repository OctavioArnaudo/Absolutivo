using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class InitParticle : InitCanvas
{
    [Header("Particle Systems")]
    [SerializeField] public ParticleSystem attackEffect;
    [SerializeField] public ParticleSystem dashEffect;
    [SerializeField] public ParticleSystem deathEffect;
    [SerializeField] public ParticleSystem idleEffect;
    [SerializeField] public ParticleSystem jumpEffect;
    [SerializeField] public ParticleSystem landEffect;
    [SerializeField] public ParticleSystem respawnEffect;
    [SerializeField] public ParticleSystem victoryEffect;
    [SerializeField] public ParticleSystem walkEffect;

    [SerializeField] protected Dictionary<string, (ParticleSystem, Func<ParticleSystem, ParticleSystem>)> particleSfxMap0;
    [SerializeField] protected Dictionary<string, AudioModel> particleSfxMap;

    public ParticleSystem PlayParticle(ParticleSystem particle)
    {
        if (particle == null)
        {
            Debug.LogWarning("ParticleSystem is null. Please provide a valid ParticleSystem.");
            return null;
        }
        particle.Play();
        return particle;
    }

    public virtual IEnumerator TriggerIdleEffect()
    {
        yield return null;
    }
    public virtual IEnumerator TriggerWalkEffect()
    {
        yield return null;
    }
    public virtual IEnumerator TriggerAttackEffect()
    {
        yield return null;
    }
    public virtual IEnumerator TriggerDashEffect()
    {
        yield return null;
    }
    public virtual IEnumerator TriggerDeathEffect()
    {
        yield return null;
    }
    public virtual IEnumerator TriggerJumpEffect()
    {
        yield return null;
    }
    public virtual IEnumerator TriggerLandEffect()
    {
        yield return null;
    }
    public virtual IEnumerator TriggerRespawnEffect()
    {
        yield return null;
    }
    public virtual IEnumerator TriggerVictoryEffect()
    {
        yield return null;
    }
}