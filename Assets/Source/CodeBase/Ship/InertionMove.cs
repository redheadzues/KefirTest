using UnityEngine;

namespace Assets.Source.CodeBase.Ship
{
    public class InertionMove
    {
        private readonly Observable<Vector2> _velocity;
        private readonly GameTransform _transform;
        private readonly float _acceleration;
        private readonly float _deceleration;
        private readonly float _maxSpeed;

        public void Accelerate(float tick)
        {
            Vector2 forward = _transform.Rotation.Value * Vector2.up;

            _velocity.Value += forward * _acceleration * tick;
            _velocity.Value = Vector2.ClampMagnitude(_velocity.Value, _maxSpeed);
        }

        public void SlowDown(float tick)
        { 
            _velocity.Value -= _velocity.Value.normalized * _deceleration * tick;
        }
    }
}
