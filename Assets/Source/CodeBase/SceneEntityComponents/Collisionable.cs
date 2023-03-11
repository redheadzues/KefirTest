using System;
using UnityEngine;

namespace Assets.Source.CodeBase.SceneEntityComponents
{
    public class Collisionable : MonoBehaviour
    {
        private EntityType _entityType;
        public EntityType EntityType => _entityType;

        public void Construct(EntityType type)
        {
            if (_entityType == EntityType.Empty)
                _entityType = type;
        }
    }
}
