public class BootstrapState : IState
{
    private GameStateMachine _gameStateMachine;

    public BootstrapState(GameStateMachine gameStateMachine)
    {
        _gameStateMachine = gameStateMachine;
    }

    public void Enter()
    {
        RegisterServices();
    }

    private void RegisterServices()
    {
        
    }
}
