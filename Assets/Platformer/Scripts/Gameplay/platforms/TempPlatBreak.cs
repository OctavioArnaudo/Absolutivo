using System;
using System.Collections.Generic;
using UnityEngine;

public class TempPlatBreak : MonoController
{
    [Header("Temporary Platform Settings")]
    [SerializeField] protected float tempPlatformBreakTime = 1.5f;
    [SerializeField] protected GameObject breakEffectPrefab;
    protected Dictionary<GameObject, float> tempPlatformTimers = new Dictionary<GameObject, float>();
    protected HashSet<GameObject> tempPlatformsBreaking = new HashSet<GameObject>();

    protected override void Update()
    {
        base.Update();
        PlatformTiming();
    }

    protected virtual void PlatformTiming()
    {
        List<GameObject> toBreak = new List<GameObject>();

        foreach (var platform in new List<GameObject>(tempPlatformTimers.Keys))
        {
            if (platform == null) continue;
            tempPlatformTimers[platform] -= Time.deltaTime;

            if (tempPlatformTimers[platform] <= 0 && !tempPlatformsBreaking.Contains(platform))
            {
                toBreak.Add(platform);
            }
        }

        foreach (var platform in toBreak)
        {
            PlatformBreak(platform);
            tempPlatformsBreaking.Add(platform);
            if (tempPlatformTimers.ContainsKey(platform))
                tempPlatformTimers.Remove(platform);
        }
    }

    protected virtual void PlatformBreak(GameObject platform)
    {
        Animator platAnim = platform.GetComponent<Animator>();
        if (platAnim != null)
            platAnim.SetTrigger("Break");

        PlayObjectAudio(platform);

        if (breakEffectPrefab != null)
        {
            Instantiate(breakEffectPrefab, platform.transform.position, Quaternion.identity);
        }

        Destroy(platform, 0.5f);
    }

    protected virtual void HandleCollisionOrTrigger(GameObject obj)
    {
        if (obj.CompareTag("TempPlatform") || obj.CompareTag("MovingTempPlatform"))
        {
            isGrounded = true;
            if (!tempPlatformsBreaking.Contains(obj))
            {
                tempPlatformTimers[obj] = tempPlatformBreakTime;
            }
        }
    }

    protected override Action<GameObject> OnDetected => DetectionHandler;
    protected virtual void DetectionHandler(GameObject gameObject)
    {
        if (gameObject.CompareTag("TempPlatform") || gameObject.CompareTag("MovingTempPlatform"))
        {
            StartPlatformTimer(gameObject);
        }
    }

    protected override void OnCollisionExit2D(Collision2D collision)
    {
        base.OnCollisionExit2D(collision);
        if (collision.gameObject.CompareTag("TempPlatform") || collision.gameObject.CompareTag("MovingTempPlatform"))
        {
            if (tempPlatformTimers.ContainsKey(collision.gameObject))
                tempPlatformTimers.Remove(collision.gameObject);
        }
    }

    public void StartPlatformTimer(GameObject platform)
    {
        if (platform == null) return;
        if (!tempPlatformsBreaking.Contains(platform))
        {
            tempPlatformTimers[platform] = tempPlatformBreakTime;
        }
    }

}