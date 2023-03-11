using Assets.Source.CodeBase.Infrustructure.StaticData;

namespace Assets.Source.CodeBase.Infrustructure.Services
{
    public class StaticDataService : IStaticDataService
    {
        public ShipStaticData GetShipStaticData()
        {
            return new ShipStaticData();
        }

        public void Load()
        {

        }
    }

}