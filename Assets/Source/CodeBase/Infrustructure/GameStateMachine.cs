using Assets.Source.CodeBase.Infrustructure.Services;
using Assets.Source.CodeBase.Infrustructure.States;
using System;
using System.Collections.Generic;

namespace Assets.Source.CodeBase.Infrustructure
{
    public class GameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;

        public GameStateMachine(AllServices services, IUpdater updater)
        {
            _states = new Dictionary<Type, IState>()
            {
                [typeof(BootstrapState)] = new BootstrapState(this, services, updater),
                [typeof(SceneInitState)] = new SceneInitState(this, services),


            };
        }

        public void Enter<TState>() where TState : IState
        {
            IState state = _states[typeof(TState)];
            state.Enter();
        }

    }
}
