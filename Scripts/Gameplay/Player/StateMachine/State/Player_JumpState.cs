using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_JumpState : Player_BaseState
{
    public Player_JumpState(Player_Function currentContext, Player_StateFactory playerStateFactory) 
    : base(currentContext, playerStateFactory) { }

    public override void EnterState() 
    {
        if (Ctx.MarikaForm != 3)
        {
            Ctx.IsJump = true;
            Ctx.HandleJump(Ctx.JumpPower);
            Ctx.ChangeAnimation(Ctx.CurrentJumpS);
            Ctx.StartCoroutine(WaitJumpAnim(Ctx.JumpDuration));
        }
        else
        {
            Ctx.ChangeAnimation(Ctx.CurrentJumpS);
            Ctx.StartCoroutine(WaitJumpAnim(Ctx.JumpDuration));
            Ctx.IsJump = true;
            Ctx.HandleJump(Ctx.JumpPower);
            Ctx.ChangeAnimation(Ctx.CurrentJumpN);
            Ctx.StartCoroutine(WaitJumpSAnim(Ctx.JumpDuration));
        }
    }

    public override void ExitState() 
    {
        Ctx.HandleJump(0f);
        //Ctx.StartCoroutine(WaitAnim(Ctx.JumpCooldown));
    }

    public override void UpdateState() 
    {
        if (Ctx.MarikaForm != 3 && _continue)
        {
            Ctx.IsJump = false;
        }
        else if (Ctx.MarikaForm == 3 && _subContinue)
        {
            Ctx.IsJump = false;
        }

        CheckSwithState();
    }

    public override void FixedUpdateState() { }

    public override void CheckSwithState() 
    {
        if (!Ctx.IsJump)
        {
            SwitchState(Factory.Fall());
        }
        else if (Ctx.IsRunPressed)
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

    bool _subContinue;
    bool _continue;

    IEnumerator WaitJumpAnim(float _lenght)
    {
        _continue = false;
        yield return new WaitForSeconds(_lenght);
        _continue = true;
    }

    IEnumerator WaitJumpSAnim(float _lenght)
    {
        _subContinue = false;
        yield return new WaitForSeconds(_lenght);
        _subContinue = true;
    }
}
