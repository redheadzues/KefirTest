using Assets.Source.CodeBase.Infrustructure.StaticData;
using Assets.Source.CodeBase.Ship;

namespace Assets.Source.CodeBase.Infrustructure.Services
{
    public interface IShipFactory : IService
    {
        ShipModel CreateShip(ShipStaticData config);
    }
}

