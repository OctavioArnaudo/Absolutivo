using UnityEngine;

public class HealthCurrent : HealthMax
{
    /// <summary>
    /// 
    /// The current hit points for the entity. This is set to the maximum HP on Awake.
    /// 
    /// </summary>
    [SerializeField]
    public int currentHP;
}