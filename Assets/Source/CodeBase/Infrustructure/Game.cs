public class Game
{
    private GameStateMachine _gameStateMachine;

    public Game()
    {
        _gameStateMachine = new GameStateMachine();
        _gameStateMachine.Enter<BootstrapState>();
    }
}
