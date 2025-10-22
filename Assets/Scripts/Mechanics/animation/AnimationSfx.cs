using System.Collections;

public class AnimationSfx : AnimationMusic
{
    public override IEnumerator TriggerAttackEffect()
    {
        base.TriggerAttackEffect();
        TriggerSfxParticle("Attack");
        TriggerAudioState("Attack");
        yield return null;
    }
    public override IEnumerator TriggerDeathEffect()
    {
        base.TriggerDeathEffect();
        TriggerSfxParticle("Death");
        TriggerAudioState("Death");
        yield return null;
    }
    public override IEnumerator TriggerIdleEffect()
    {
        base.TriggerIdleEffect();
        TriggerSfxParticle("Idle");
        TriggerAudioState("Idle");
        yield return null;
    }
    public override IEnumerator TriggerWalkEffect()
    {
        base.TriggerWalkEffect();
        TriggerSfxParticle("Walk");
        TriggerAudioState("Walk");
        yield return null;
    }
    public IEnumerator TriggerSfxParticle(string stateName)
    {
        if (particleSfxMap.TryGetValue(stateName, out var audioState))
        {
            audioState.Invoke();
        }
        yield return null;
    }
}