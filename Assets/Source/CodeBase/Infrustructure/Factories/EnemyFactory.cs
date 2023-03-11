using Assets.Source.CodeBase.Infrustructure.Services;

namespace Assets.Source.CodeBase.Infrustructure.Factories
{
    public class EnemyFactory : IEnemyFactory
    {
        private readonly IStaticDataService _staticDataService;

        public EnemyFactory(IStaticDataService staticDataService)
        {
            _staticDataService = staticDataService;
        }
    }

}