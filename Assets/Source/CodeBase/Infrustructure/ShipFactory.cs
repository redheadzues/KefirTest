using Assets.Source.CodeBase.Ship;

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
