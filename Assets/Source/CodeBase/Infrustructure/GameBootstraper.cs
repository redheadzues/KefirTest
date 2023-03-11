using UnityEngine;

namespace Assets.Source.CodeBase.Infrustructure
{
    public class GameBootstraper : MonoBehaviour
    {
        private Game _game;

        private void Awake()
        {
            _game = new Game();
        }
    }
}
