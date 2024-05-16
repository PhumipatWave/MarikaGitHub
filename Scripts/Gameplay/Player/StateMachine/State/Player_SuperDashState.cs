using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_SuperDashState : Player_BaseState
{
    public Player_SuperDashState(Player_Function currentContext, Player_StateFactory playerStateFactory)
    : base(currentContext, playerStateFactory) { }

    public override void EnterState() 
    {
        Ctx.IsDash = true;
        Ctx.HandleDash(Ctx.DashPower);
        Ctx.ChangeAnimation(Ctx.SuperDashS_NanoMachine);
        Ctx.StartCoroutine(WaitRunAnim(Ctx.GetAnimLenght(Ctx.SuperDashS_NanoMachine)));
    }

    public override void ExitState() 
    {
        Ctx.HandleDash(0f);
        Ctx.ChangeAnimation(Ctx.SuperDashE_NanoMachine);
        Ctx.StartCoroutine(WaitRunAnim(Ctx.GetAnimLenght(Ctx.SuperDashE_NanoMachine)));
    }

    public override void UpdateState() 
    {
        if (_continue)
        {
            Ctx.ChangeAnimation(Ctx.SuperDashN_NanoMachine);
        }

        CheckSwithState();
    }

    public override void FixedUpdateState() { }

    public override void CheckSwithState() 
    { 
        if (!Ctx.IsDashPressed)
        {
            SwitchState(Factory.Idle());
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