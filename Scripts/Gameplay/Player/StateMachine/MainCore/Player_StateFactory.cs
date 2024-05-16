using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_StateFactory
{
    Player_Function _context;

    public Player_StateFactory( Player_Function currentContext)
    {
        _context = currentContext;
    }

    public Player_BaseState Idle()
    {
        return new Player_IdleState(_context, this);
    }

    public Player_BaseState Run()
    {
        return new Player_RunState(_context, this);
    }

    public Player_BaseState Jump()
    {
        return new Player_JumpState(_context, this);
    }

    public Player_BaseState Fall()
    {
        return new Player_FallState(_context, this);
    }

    public Player_BaseState Dash()
    {
        return new Player_DashState(_context, this);
    }

    public Player_BaseState AirDash()
    {
        return new Player_AirDashState(_context, this);
    }

    public Player_BaseState SuperDash()
    {
        return new Player_SuperDashState(_context, this);
    }

    public Player_BaseState AirSuperDash()
    {
        return new Player_AirSuperDashState(_context, this);
    }

    public Player_BaseState AirDashAtk()
    {
        return new Player_AirDashAtkState(_context, this);
    }

    public Player_BaseState DashAtk()
    {
        return new Player_DashAtkState(_context, this);
    }

    public Player_BaseState AirLAtk()
    {
        return new Player_AirLAtkState(_context, this);
    }

    public Player_BaseState AirRAtk()
    {
        return new Player_AirRAtkState(_context, this);
    }

    public Player_BaseState LAtk()
    {
        return new Player_LAtkState(_context, this);
    }

    public Player_BaseState RAtk()
    {
        return new Player_RAtkState(_context, this);
    }

    public Player_BaseState ULAtk()
    {
        return new Player_LAtkState(_context, this);
    }

    public Player_BaseState URAtk()
    {
        return new Player_URAtkState(_context, this);
    }

    public Player_BaseState DLAtk()
    {
        return new Player_DLAtkState(_context, this);
    }

    public Player_BaseState DRAtk()
    {
        return new Player_DRAtkState(_context, this);
    }

    /*public Player_BaseState Dead()
    {
        return new Player_DeadState(_context, this);
    }*/

    public Player_BaseState Interact()
    {
        return new Player_InteractState(_context, this);
    }

    public Player_BaseState Map()
    {
        return new Player_MapState(_context, this);
    }

    public Player_BaseState Upgrade()
    {
        return new Player_UpgradeState(_context, this);
    }

    public Player_BaseState Accessorie()
    {
        return new Player_AccessorieState(_context, this);
    }
}
