using System;
using System.Collections.Generic;

public class GameStateMachine
{
    private readonly Dictionary<Type, IState> _states;

    public GameStateMachine()
    {
        _states = new Dictionary<Type, IState>()
        {
            [typeof(BootstrapState)] = new BootstrapState(this),
            [typeof(SceneInitState)] = new SceneInitState(this),


        };
    }

    public void Enter<TState>() where TState : IState
    {
        IState state = _states[typeof(TState)];
        state.Enter();
    }

}
