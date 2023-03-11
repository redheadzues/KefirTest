using Assets.Source.CodeBase.Infrustructure.StaticData;

namespace Assets.Source.CodeBase.Infrustructure.Services
{
    public interface IStaticDataService : IService
    {
        void Load();
        ShipStaticData GetShipStaticData();
    }
}