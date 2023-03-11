using Assets.Source.CodeBase.Infrustructure.Services;

namespace Assets.Source.CodeBase.Infrustructure.States
{
    public class SceneInitState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly IShipFactory _shipFactory;
        private readonly IEnemyFactory _enemyFactory;

        public SceneInitState(GameStateMachine gameStateMachine, AllServices services)
        {
            _gameStateMachine = gameStateMachine;
            _shipFactory = services.Single<IShipFactory>();
            _enemyFactory = services.Single<IEnemyFactory>();
        }

        public void Enter()
        {
            _shipFactory.CreateShip();
        }
    }
}
