using Assets.Source.CodeBase.Ship;
using UnityEngine;

namespace Assets.Source.CodeBase.Infrustructure.Services
{
    public interface IViewFactory : IService
    {
        void CreateEntityView(GameTransform transform, Sprite viewSprite, EntityType entityType);
    }
}