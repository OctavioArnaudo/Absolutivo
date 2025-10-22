using Unity.Cinemachine;
using UnityEngine;

[RequireComponent(typeof(CinemachineCamera))]
public class BaseCinemachine : BaseCamera
{
    [SerializeField] protected CinemachineCamera vcam;
}