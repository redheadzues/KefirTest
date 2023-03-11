public class BootstrapState : IState
{
    private readonly GameStateMachine _gameStateMachine;
    private readonly AllServices _services;

    public BootstrapState(GameStateMachine gameStateMachine, AllServices services)
    {
        _gameStateMachine = gameStateMachine;
        _services = services;
    }

    public void Enter()
    {
        RegisterServices();
    }

    private void RegisterServices()
    {
        RegisterStaticData();

        _services.RegisterSingle<IShipFactory>(new ShipFactory());
        _services.RegisterSingle<IEnemyFactory>(new EnemyFactory());
    }

    private void RegisterStaticData()
    {
        IStaticDataService staticData = new StaticDataService();
        staticData.Load();
        _services.RegisterSingle(staticData);
    }
}
