using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player_BaseState
{
    private Player_Function _ctx;
    private Player_StateFactory _factory;
    protected Player_Function Ctx { get { return _ctx; } }
    protected Player_StateFactory Factory { get { return _factory; } }

    public Player_BaseState(Player_Function currentContext, Player_StateFactory playerStateFactory)
    {
        _ctx = currentContext;
        _factory = playerStateFactory;
    }

    public abstract void EnterState();

    public abstract void ExitState();

    public abstract void UpdateState();

    public abstract void FixedUpdateState();

    public abstract void CheckSwithState();

    public void UpdateStates()
    {
        UpdateState();
    }

    public void FixedUpdateStates()
    {
        FixedUpdateState();
    }

    protected void SwitchState(Player_BaseState newState) 
    {
        Debug.Log(_ctx.CurrentState);

        // Current state exits
        ExitState();

        // New state enters
        newState.EnterState();

        // Switch current state of context
        _ctx.CurrentState = newState;

        Debug.Log(_ctx.CurrentState);
    }
}
