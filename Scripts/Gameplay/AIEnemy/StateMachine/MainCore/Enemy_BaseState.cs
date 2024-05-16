using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy_BaseState
{
    //private Enemy_Function _ctx;
    private Enemy_StateFactory _factory;
    //protected Enemy_Function Ctx { get {  return _ctx; } }
    protected Enemy_StateFactory Factory { get {  return _factory; } }

    public bool _continue;

    /*public Enemy_BaseState(Enemy_Function currentContext, Enemy_StateFactory enemyStateFactory)
    {
        _ctx = currentContext;
        _factory = enemyStateFactory;
    }*/

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

    /*protected void SwitchState(Player_BaseState newState)
    {
        Debug.Log(_ctx.CurrentState);

        // Current state exits
        ExitState();

        // New state enters
        newState.EnterState();

        // Switch current state of context
        _ctx.CurrentState = newState;

        Debug.Log(_ctx.CurrentState);
    }*/
}