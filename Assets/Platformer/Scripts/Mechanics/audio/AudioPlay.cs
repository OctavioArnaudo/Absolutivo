using UnityEngine;

public class AudioPlay : SpriteFlipper
{
    public void PlayClipAudio(AudioClip audioClip)
    {
        if (audioClip == null)
        {
            Debug.LogWarning("AudioClip is null. Please provide a valid AudioClip.", this);
            return;
        }
        else
        {
            clip = audioClip;
        }
        if (audioSource != null)
        {
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.LogWarning($"AudioSource or AudioClip '{audioClip?.name}' is not set.", this);
        }
    }
    public void PlayObjectAudio(GameObject obj)
    {
        AudioSource objAudio = obj.GetComponent<AudioSource>();
        if (objAudio != null && objAudio.clip != null)
        {
            PlayClipAudio(objAudio.clip);
        }
    }

}