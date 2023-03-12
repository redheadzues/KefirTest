using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Source.CodeBase.Weapon
{
    public class Weapon 
    {
        private readonly IReadOnlyObservable<Vector2> _parentPosition;
        private readonly IReadOnlyObservable<Quaternion> _parentRotation;
        private readonly IProjectileFactory _factory;
        private ProjectileType _projectile;

        public void Fire()
        {
            _factory.Create(_projectile, _parentPosition.Value, _parentRotation.Value);
        }
    }

    public interface IProjectileFactory
    {
        void Create(ProjectileType projectile, Vector2 position, Quaternion rotation);
    }

    public class ProjectileFactory : IProjectileFactory
    {
        public void Create(ProjectileType projectile, Vector2 position, Quaternion rotation)
        {
            throw new NotImplementedException();
        }
    }
}
