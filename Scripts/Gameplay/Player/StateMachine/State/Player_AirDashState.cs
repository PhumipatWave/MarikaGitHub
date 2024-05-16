using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AirDashState : Player_BaseState
{
    public Player_AirDashState(Player_Function currentContext, Player_StateFactory playerStateFactory) 
    : base(currentContext, playerStateFactory) { }

    public override void EnterState()
    {
        Ctx.IsAirDash = true;
        Ctx.HandleDash(Ctx.DashPower);
        Ctx.ChangeAnimation(Ctx.CurrentAirDash);
        Ctx.StartCoroutine(WaitAirDashAnim(Ctx.DashDuration));
    }

    public override void ExitState() 
    {
        Ctx.RB.gravityScale = Ctx.OriginalGravity;
    }

    public override void UpdateState()
    {
        if (_continue)
        {
            Ctx.IsAirDash = false;
        }

        CheckSwithState();
    }

    public override void FixedUpdateState() { }

    public override void CheckSwithState()
    {
        if (!Ctx.IsAirDash)
        {
            Ctx.HandleDash(0f);
            SwitchState(Factory.Fall());
        }
    }

    bool _continue;

    IEnumerator WaitAirDashAnim(float _lenght)
    {
        _continue = false;
        Ctx.OriginalGravity = Ctx.RB.gravityScale;
        Ctx.RB.gravityScale = 0f;
        yield return new WaitForSeconds(_lenght);
        _continue = true;
    }
}
