using UnityEngine.InputSystem;

namespace Assets.Source.CodeBase.Ship
{
    public class ShipInputRouter : IUpdatable
    {
        private readonly PlayerInput _playerInput = new PlayerInput();
        private readonly InertionMove _inertionMove;
        private readonly ShipRotator _shipRotator;

        public ShipInputRouter(InertionMove inertionMove, ShipRotator shipRotator)
        {
            _inertionMove = inertionMove;
            _shipRotator = shipRotator;
        }

        public void Update(float tick)
        {
            ChangeVelocity(tick);
            Rotate(tick);
        }

        private void ChangeVelocity(float tick)
        {
            if (CheckAccelerate() == true)
                _inertionMove.Accelerate(tick);
            else
                _inertionMove.SlowDown(tick);
        }

        private bool CheckAccelerate()
        {
            return _playerInput.Ship.MoveForward.phase == InputActionPhase.Performed;
        }

        private void Rotate(float tick)
        {
            float direction = _playerInput.Ship.Rotate.ReadValue<float>();

            if (direction != 0)
                _shipRotator.Rotate(tick, direction);
        }
    }
}
