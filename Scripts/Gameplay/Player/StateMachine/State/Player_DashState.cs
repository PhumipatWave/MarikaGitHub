using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_DashState : Player_BaseState
{
    public Player_DashState(Player_Function currentContext, Player_StateFactory playerStateFactory) 
    : base(currentContext, playerStateFactory) { }

    public override void EnterState() 
    {
        Ctx.IsDash = true;
        Ctx.HandleDash(Ctx.DashPower);
        Ctx.ChangeAnimation(Ctx.CurrentDash);
        Ctx.StartCoroutine(WaitDashAnim(Ctx.DashDuration));
    }

    public override void ExitState() 
    {
        Ctx.HandleDash(0f);
    }

    public override void UpdateState() 
    {
        if (_continue)
        {
            Ctx.IsDash = false;
        }

        CheckSwithState();
    }

    public override void FixedUpdateState() { }

    public override void CheckSwithState() 
    {
        if (!Ctx.IsDash)
        {
            SwitchState(Factory.Idle());
        }
    }

    bool _continue;

    IEnumerator WaitDashAnim(float _lenght)
    {
        _continue = false;
        yield return new WaitForSeconds(_lenght);
        _continue = true;
    }
}
