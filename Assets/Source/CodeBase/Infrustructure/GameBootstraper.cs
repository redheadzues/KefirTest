using UnityEngine;

public class GameBootstraper : MonoBehaviour
{
    private Game _game;

    private void Awake()
    {
        _game = new Game();
    }
}
