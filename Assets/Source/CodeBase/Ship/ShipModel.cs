using UnityEngine;

namespace Assets.Source.CodeBase.Ship
{
    public class ShipModel
    {
        public readonly GameTransform _transform;
        public readonly Observable<Vector2> Velocity;
        public readonly float Acceleration;
        public readonly float Deceleration;
        public readonly float MaxSpeed;
        public readonly float RotationSpeed;
    }
}
