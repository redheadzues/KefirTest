using Assets.Source.CodeBase.Infrustructure.Services;
using Assets.Source.CodeBase.Infrustructure.StaticData;
using Assets.Source.CodeBase.Ship;

namespace Assets.Source.CodeBase.Infrustructure.Factories
{
    public class ShipFactory : IShipFactory
    {
        private readonly IUpdater _updater;

        public ShipFactory(IUpdater updater)
        {
            _updater = updater;
        }

        public ShipModel CreateShip(ShipStaticData config)
        {
            ShipModel shipModel = new ShipModel(config);
            InertionMove inertionMove = new InertionMove(shipModel);
            ShipMover shipMover = new ShipMover(shipModel.Transform, shipModel.Velocity);
            ShipRotator shipRotator = new ShipRotator(shipModel.Transform, shipModel.RotationSpeed);
            ShipPositionClamper positionClamper = new ShipPositionClamper(shipModel.Transform);
            ShipInputRouter shipIntup = new ShipInputRouter(inertionMove, shipRotator);

            _updater.AddListener(shipMover);
            _updater.AddListener(positionClamper);
            _updater.AddListener(shipIntup);


            return shipModel;
        }
    }
}
