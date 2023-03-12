using Assets.Source.CodeBase.Infrustructure.Services;
using Assets.Source.CodeBase.Infrustructure.StaticData;
using Assets.Source.CodeBase.Ship;

namespace Assets.Source.CodeBase.Infrustructure.States
{
    public class SceneInitState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly IShipFactory _shipFactory;
        private readonly IStaticDataService _staticDataService;
        private readonly IViewFactory _viewFactory;

        public SceneInitState(GameStateMachine gameStateMachine, AllServices services)
        {
            _gameStateMachine = gameStateMachine;
            _shipFactory = services.Get<IShipFactory>();
            _staticDataService = services.Get<IStaticDataService>();
            _viewFactory = services.Get<IViewFactory>();
        }

        public void Enter()
        {
            ShipStaticData shipStaticData = _staticDataService.GetShipStaticData();
            ShipModel ship = _shipFactory.CreateShip(shipStaticData);

            _viewFactory.CreateEntityView(ship.Transform, shipStaticData.ViewSprite, shipStaticData.EntityType);

        }
    }
}
