using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_FallState : Player_BaseState
{
    public Player_FallState(Player_Function currentContext, Player_StateFactory playerStateFactory)
    : base(currentContext, playerStateFactory) { }

    public override void EnterState() 
    {
        Ctx.IsFall = true;

        Ctx.ChangeAnimation(Ctx.CurrentFallS);
        Ctx.StartCoroutine(WaitFallAnim(Ctx.GetAnimLenght(Ctx.CurrentFallS)));
    }

    public override void ExitState() 
    {
        Ctx.ChangeAnimation(Ctx.CurrentFallE);
        Ctx.StartCoroutine(WaitFallAnim(Ctx.GetAnimLenght(Ctx.CurrentFallE)));
        Ctx.RB.velocity = Ctx.VectorZero;
    }

    public override void UpdateState() 
    {
        if (_continue)
        {
            Ctx.ChangeAnimation(Ctx.CurrentFallN);
        }

        CheckSwithState();
    }

    public override void FixedUpdateState() 
    {
        Ctx.FallingGravity();
    }

    public override void CheckSwithState() 
    {
        if (Ctx.IsGround)
        {
            Ctx.IsFall = false;
            SwitchState(Factory.Idle());
        }
        else if (Ctx.IsRunPressed && !Ctx.IsGround)
        {
            Ctx.HandleRun(Ctx.MoveSpeed * 3f);
        }
        else if (Ctx.IsDashPressed && !Ctx.AirDashLock)
        {
            if (!Ctx.SuperDashLock)
            {
                SwitchState(Factory.AirSuperDash());
            }
            else if (!Ctx.DashAtkLock)
            {
                SwitchState(Factory.AirDashAtk());
            }
            else
            {
                SwitchState(Factory.AirDash());
            }
        }
        else if (Ctx.IsLAtkPressed && !Ctx.LAtkLock)
        {
            SwitchState(Factory.AirLAtk());
        }
        else if (Ctx.IsRAtkPressed && !Ctx.RAtkLock)
        {
            SwitchState(Factory.AirRAtk());
        }
    }

    bool _continue;

    IEnumerator WaitFallAnim(float _lenght)
    {
        _continue = false;
        yield return new WaitForSeconds(_lenght);
        _continue = true;
    }
}
