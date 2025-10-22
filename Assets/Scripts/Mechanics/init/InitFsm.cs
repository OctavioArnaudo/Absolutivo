using System.Collections;
using UnityEngine;
using System;

[Serializable]
public class InitFsm : InitCoroutine
{
    private AnimatorFSM fsm;

    protected override void Start()
    {
        base.Start();
        fsm = new AnimatorFSM();
        fsm.ChangeState(new PlayerIdleState(animatorComponent, 0f));
    }

    protected override void Update()
    {
        base.Update();
        fsm.Update();

        if (Input.GetKeyDown(KeyCode.Space))
            fsm.ChangeState(new PlayerMeleeAttackState(animatorComponent));
        else if (Input.GetKeyDown(KeyCode.H))
            fsm.ChangeState(new PlayerHurtState(animatorComponent, 80));
    }

    public IEnumerator OnAnimatorStateEnter(string stateId)
    {
        switch (stateId)
        {
            case "Idle":
                fsm.ChangeState(new PlayerIdleState(animatorComponent, moveSpeed));
                break;
            case "AttackMelee":
                fsm.ChangeState(new PlayerMeleeAttackState(animatorComponent));
                break;
            case "AttackRanged":
                fsm.ChangeState(new PlayerMeleeAttackState(animatorComponent));
                break;
            case "Hurt":
                fsm.ChangeState(new PlayerHurtState(animatorComponent, currentHP));
                break;
            case "Death":
                fsm.ChangeState(new PlayerDeathState(animatorComponent));
                break;
        }
        yield return null;
    }
}
