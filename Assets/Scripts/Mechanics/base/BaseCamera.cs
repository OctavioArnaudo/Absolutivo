using UnityEngine;

[RequireComponent(typeof(Camera))]
public class BaseCamera : BaseAudioSource
{
    [SerializeField] protected Camera cam;
}