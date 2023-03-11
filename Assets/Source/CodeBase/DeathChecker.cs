using System.Collections.Generic;

namespace Assets.Source.CodeBase
{
    public class DeathChecker
    {
        private List<EntityType> _killers = new List<EntityType>();

        public void AddKiller(EntityType type) => 
            _killers.Add(type);

        public bool CheckKiller(EntityType type) => 
            _killers.Contains(type);
    }
}
