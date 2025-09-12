using UnityEngine;

/// <summary>
/// 
/// SpawnPoint is a virtual camera that defines a spawn point in the scene.
/// 
/// </summary>
[System.Serializable]
public class SpawnPoint : PlayerModel
{
    /// <summary>
    /// The spawn point in the scene.
    /// </summary>
    public Transform spawnPoint;
}