using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MapState : Player_BaseState
{
    public Player_MapState(Player_Function currentContext, Player_StateFactory playerStateFactory)
    : base(currentContext, playerStateFactory) { }

    public override void EnterState() { }

    public override void ExitState() { }

    public override void UpdateState() { }

    public override void FixedUpdateState() { }

    public override void CheckSwithState() { }
}
