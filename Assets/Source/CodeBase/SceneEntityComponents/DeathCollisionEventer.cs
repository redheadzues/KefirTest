using System;
using UnityEngine;

namespace Assets.Source.CodeBase.SceneEntityComponents
{
    public class DeathCollisionEventer : MonoBehaviour
    {
        private DeathChecker _death;
        private int _entityId;

        public event Action<int> Died;

        public void Construct(DeathChecker death, int id)
        {
            _death = death;
            _entityId = id; 
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Collisionable collisionable))
                if (_death.CheckKiller(collisionable.EntityType))
                    Died?.Invoke(_entityId);
        }
    }
}
