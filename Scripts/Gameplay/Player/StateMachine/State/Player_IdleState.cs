using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_IdleState : Player_BaseState
{
    public Player_IdleState(Player_Function currentContext, Player_StateFactory playerStateFactory)
    : base(currentContext, playerStateFactory) { }

    public override void EnterState() 
    {
        Ctx.IsIdle = true;
        Ctx.ChangeAnimation(Ctx.CurrentIdle);
    }

    public override void ExitState() 
    {
        Ctx.IsIdle = false;
    }

    public override void UpdateState() 
    {
        CheckSwithState();
    }

    public override void FixedUpdateState() 
    {
        
    }

    public override void CheckSwithState() 
    {
        if (Ctx.IsRunPressed)
        {
            SwitchState(Factory.Run());
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
}
