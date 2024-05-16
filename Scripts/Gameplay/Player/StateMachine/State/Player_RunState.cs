using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_RunState : Player_BaseState
{
    public Player_RunState(Player_Function currentContext, Player_StateFactory playerStateFactory)
    : base(currentContext, playerStateFactory) { }

    public override void EnterState() 
    {
        Ctx.IsRun = true;
        Ctx.ChangeAnimation(Ctx.CurrentRunS);
        Ctx.StartCoroutine(WaitRunAnim(Ctx.GetAnimLenght(Ctx.CurrentRunS)));
    }

    public override void ExitState() 
    {
        Ctx.ChangeAnimation(Ctx.CurrentRunE);
        Ctx.StartCoroutine(WaitRunAnim(Ctx.GetAnimLenght(Ctx.CurrentRunE)));
        Ctx.HandleRun(0f);
    }

    public override void UpdateState() 
    {
        if (_continue)
        {
            Ctx.ChangeAnimation(Ctx.CurrentRunN);
        }

        CheckSwithState();
    }

    public override void FixedUpdateState() 
    {
        Ctx.HandleRun(Ctx.MoveSpeed);
        /*Debug.Log(Ctx.CurrentMoveSpeed);*/
    }

    public override void CheckSwithState() 
    {
        if (Ctx.CurrentMoveSpeed == Ctx.VectorZero)
        {
            SwitchState(Factory.Idle());
        }
        else if (Ctx.IsJumpPressed)
        {
            SwitchState(Factory.Jump());
        }
        else if (!Ctx.IsGround && !Ctx.IsJump)
        {
            SwitchState(Factory.Fall());
        }
        else if (Ctx.IsDashPressed)
        {
            if (!Ctx.SuperDashLock)
            {
                SwitchState(Factory.SuperDash());
            }
            else if (!Ctx.DashAtkLock)
            {
                SwitchState(Factory.DashAtk());
            }
            else
            {
                SwitchState(Factory.Dash());
            }
        }
        else if (Ctx.IsLAtkPressed && !Ctx.LAtkLock)
        {
            SwitchState(Factory.LAtk());
        }
        else if (Ctx.IsRAtkPressed && !Ctx.RAtkLock)
        {
            SwitchState(Factory.RAtk());
        }
        else if (Ctx.IsULAtkPressed && !Ctx.ULAtkLock)
        {
            SwitchState(Factory.ULAtk());
        }
        else if (Ctx.IsURAtkPressed && !Ctx.URAtkLock)
        {
            SwitchState(Factory.URAtk());
        }
        else if (Ctx.IsDLAtkPressed && !Ctx.DLAtkLock)
        {
            SwitchState(Factory.DLAtk());
        }
        else if (Ctx.IsDRAtkPressed && !Ctx.DRAtkLock)
        {
            SwitchState(Factory.DRAtk());
        }
    }

    bool _continue;

    IEnumerator WaitRunAnim(float _lenght)
    {
        _continue = false;
        yield return new WaitForSeconds(_lenght);
        _continue = true;
    }
}
