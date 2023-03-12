using UnityEngine;

namespace Assets.Source.CodeBase.Ship
{
    public class InertionMove
    {
        private readonly ShipModel _model;

        public InertionMove(ShipModel model)
        {
            _model = model;
        }

        public void Accelerate(float tick)
        {
            Vector2 forward = _model.Transform.Rotation.Value * Vector2.up;

            _model.Velocity.Value += forward * _model.Acceleration * tick;
            _model.Velocity.Value = Vector2.ClampMagnitude(_model.Velocity.Value, _model.MaxSpeed);
            MonoBehaviour.print(_model.Velocity.Value);
        }

        public void SlowDown(float tick)
        {
            _model.Velocity.Value -= _model.Velocity.Value.normalized * _model.Deceleration * tick;
        }
    }
}
