using UnityEngine;

[
    RequireComponent(
        typeof(AudioSource)
    )
]
public class BaseAudioSource : BaseAnimator
{
    /*internal new*/
    [SerializeField] protected AudioSource audioSource;
    protected AudioClip clip;
}
