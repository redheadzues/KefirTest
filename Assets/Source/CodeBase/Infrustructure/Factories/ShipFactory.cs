using Assets.Source.CodeBase.Infrustructure.Services;
using Assets.Source.CodeBase.Ship;

namespace Assets.Source.CodeBase.Infrustructure.Factories
{
    public class ShipFactory : IShipFactory
    {
        public ShipFactory()
        {

        }

        public ShipModel CreateShip(ShipConfing config)
        {
            return new ShipModel();
        }
    }
}
