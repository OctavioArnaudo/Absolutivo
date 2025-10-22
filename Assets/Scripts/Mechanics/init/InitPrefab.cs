using UnityEngine;
using System;

[Serializable]
public class InitPrefab : InitParticle
{
    [SerializeField] public GameObject ammoPickupPrefab;
    [SerializeField] public GameObject barrelPrefab;
    [SerializeField] public GameObject boulderPrefab;
    [SerializeField] public GameObject breakableWallPrefab;
    [SerializeField] public GameObject breakEffectPrefab;
    [SerializeField] public GameObject buttonPrefab;
    [SerializeField] public GameObject checkpointPrefab;
    [SerializeField] public GameObject cratePrefab;
    [SerializeField] public GameObject doorPrefab;
    [SerializeField] public GameObject elevatorPrefab;
    [SerializeField] public GameObject flameTrapPrefab;
    [SerializeField] public GameObject healthPickupPrefab;
    [SerializeField] public GameObject leverPrefab;
    [SerializeField] public GameObject meleeEnemyPrefab;
    [SerializeField] public GameObject movingPlatformPrefab;
    [SerializeField] public GameObject oneWayPlatformPrefab;
    [SerializeField] public GameObject platformPathPrefab;
    [SerializeField] public GameObject playerPrefab;
    [SerializeField] public GameObject projectilePrefab;
    [SerializeField] public GameObject rangedEnemyPrefab;
    [SerializeField] public GameObject sawTrapPrefab;
    [SerializeField] public GameObject spawnPointPrefab;
    [SerializeField] public GameObject spikeTrapPrefab;
    [SerializeField] public GameObject trapPrefab;
    [SerializeField] public GameObject victoryPrefab;
    [SerializeField] public GameObject wallPrefab;
    [SerializeField] public GameObject weaponPickupPrefab;
    [SerializeField] public GameObject weaponPrefab;

    protected override void Awake()
    {
        base.Awake();
        ammoPickupPrefab ??= gameObject;
        barrelPrefab ??= gameObject;
        boulderPrefab ??= gameObject;
        breakableWallPrefab ??= gameObject;
        breakEffectPrefab ??= gameObject;
        buttonPrefab ??= gameObject;
        checkpointPrefab ??= gameObject;
        cratePrefab ??= gameObject;
        doorPrefab ??= gameObject;
        elevatorPrefab ??= gameObject;
        flameTrapPrefab ??= gameObject;
        healthPickupPrefab ??= gameObject;
        leverPrefab ??= gameObject;
        meleeEnemyPrefab ??= gameObject;
        movingPlatformPrefab ??= gameObject;
        oneWayPlatformPrefab ??= gameObject;
        platformPathPrefab ??= gameObject;
        playerPrefab ??= gameObject;
        projectilePrefab ??= gameObject;
        rangedEnemyPrefab ??= gameObject;
        sawTrapPrefab ??= gameObject;
        spawnPointPrefab ??= gameObject;
        spikeTrapPrefab ??= gameObject;
        trapPrefab ??= gameObject;
        victoryPrefab ??= gameObject;
        wallPrefab ??= gameObject;
        weaponPickupPrefab ??= gameObject;
        weaponPrefab ??= gameObject;
        AssignDefaults(this, gameObject);
    }
}