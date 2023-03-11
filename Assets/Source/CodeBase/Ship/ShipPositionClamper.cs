using UnityEngine;

namespace Assets.Source.CodeBase.Ship
{
    public class ShipPositionClamper : IUpdatable
    {
        private readonly GameTransform _transform;

        public void Update(float tick)
        {
            Vector2 position = _transform.Position.Value;



            _transform.Position.Value = position;
        }
    }
}
