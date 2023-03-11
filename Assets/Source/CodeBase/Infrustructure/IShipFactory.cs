using Assets.Source.CodeBase.Ship;

public interface IShipFactory : IService
{
    ShipModel CreateShip(ShipConfing config);
}
