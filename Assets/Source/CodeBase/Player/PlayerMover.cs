using UnityEngine;

namespace Assets.Source.CodeBase.Player
{
    public class PlayerMover
    {
        private readonly GameTransform _transform;
        private readonly Input _input;

        public PlayerMover(GameTransform transform)
        {
            _transform = transform;
        }

        public void SetPosition(Vector2 position)
        {
            _transform.Position.Value = position;
        }

        public void SetRotation(Quaternion rotation)
        {
            _transform.Rotation.Value = rotation;
        }
    }
}
