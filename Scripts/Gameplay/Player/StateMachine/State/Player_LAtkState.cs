using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_LAtkState : Player_BaseState
{
    public Player_LAtkState(Player_Function currentContext, Player_StateFactory playerStateFactory)
    : base(currentContext, playerStateFactory) { }

    public override void EnterState() 
    {
        switch (Ctx.MarikaForm)
        {
            case 2:
                Ctx.ChangeAnimation(Ctx.LAtkS_Magical);
                break;
            case 3:

                break; 
            case 4:

                break;
            case 5:

                break;
        }
    }

    public override void ExitState() { }

    public override void UpdateState() 
    {
        // In magical form if left click count = 2; play LAtkN_Magical
    }

    public override void FixedUpdateState() { }

    public override void CheckSwithState() { }
}
