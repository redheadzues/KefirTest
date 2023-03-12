using Assets.Source.CodeBase.Infrustructure.StaticData;
using UnityEngine;

namespace Assets.Source.CodeBase.Infrustructure.Services
{
    public class StaticDataService : IStaticDataService
    {
        private ShipStaticData _shipData;

        public ShipStaticData GetShipStaticData()
        {
            return _shipData;
        }

        public void Load()
        {
            _shipData = Resources.Load<ShipStaticData>("ShipStaticData");
        }
    }

}