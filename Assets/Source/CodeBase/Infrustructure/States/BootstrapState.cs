using Assets.Source.CodeBase.Infrustructure.Factories;
using Assets.Source.CodeBase.Infrustructure.Services;

namespace Assets.Source.CodeBase.Infrustructure.States
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly AllServices _services;
        private readonly IUpdater _updater;

        public BootstrapState(GameStateMachine gameStateMachine, AllServices services, IUpdater updater)
        {
            _gameStateMachine = gameStateMachine;
            _services = services;
            _updater = updater;
            RegisterServices();
        }

        public void Enter()
        {

            _services.Get<IStaticDataService>().Load();
            _gameStateMachine.Enter<SceneInitState>();
        }

        private void RegisterServices()
        {
            _services.RegisterSingle(_updater);
            _services.RegisterSingle<IAsserProvider>(new AssetProvider());
            _services.RegisterSingle<IStaticDataService>(new StaticDataService());
            _services.RegisterSingle<IShipFactory>(new ShipFactory(_services.Get<IUpdater>()));
            _services.RegisterSingle<IEnemyFactory>(new EnemyFactory(_services.Get<IStaticDataService>()));
            _services.RegisterSingle<IUiFactory>(new UiFactory());
            _services.RegisterSingle<IViewFactory>(new ViewFactory(_services.Get<IAsserProvider>()));
        }

    }
}