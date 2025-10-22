using System.Collections;

public class AnimationMusic : AnimationMapping
{
    public override IEnumerator TriggerAudioState(string stateName)
    {
        base.TriggerAudioState(stateName);
        if (stateAudioMap.TryGetValue(stateName, out var audioState))
        {
            audioState.Invoke();
        }
        yield return null;
    }
}