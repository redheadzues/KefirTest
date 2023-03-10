public class SceneInitState : IState
{
    private GameStateMachine _gameStateMachine;

    public SceneInitState(GameStateMachine gameStateMachine)
    {
        _gameStateMachine = gameStateMachine;
    }

    public void Enter()
    {

    }
}
