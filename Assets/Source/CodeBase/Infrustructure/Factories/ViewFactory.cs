using Assets.Source.CodeBase.Infrustructure.Services;
using Assets.Source.CodeBase.SceneEntityComponents;
using System;
using UnityEngine;

namespace Assets.Source.CodeBase.Infrustructure.Factories
{
    public class ViewFactory : IViewFactory
    {
        private readonly IAsserProvider _asserProvider;
        private readonly IStaticDataService _staticDataService;

        public ViewFactory(IAsserProvider asserProvider)
        {
            _asserProvider = asserProvider;
        }

        public void CreateEntityView(GameTransform transform, Sprite viewSprite, EntityType entityType)
        {
            GameObject entity = _asserProvider.Instantiate(AssetPath.EntityView);
            entity.GetComponent<TransformSetter>().Construct(transform.Position, transform.Rotation);
            DeathChecker deathChecker = GetDeathChecker(entityType);
            entity.GetComponent<DeathCollisionEventer>().Construct(deathChecker, 7);
            entity.GetComponent<Collisionable>().Construct(entityType);
            entity.GetComponent<SpriteRenderer>().sprite = viewSprite;
        }

        private DeathChecker GetDeathChecker(EntityType entityType)
        {
            return new DeathChecker();
        }
    }
}