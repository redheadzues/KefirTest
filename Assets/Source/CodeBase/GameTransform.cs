﻿using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class GameTransform
    {
        public Observable<Vector2> Position { get;  }
        public Observable<Quaternion> Rotation { get; }

        public GameTransform(Vector2 startPoint, Quaternion startRotation)
        {
            Position = new Observable<Vector2>(startPoint);
            Rotation = new Observable<Quaternion>(startRotation);
        }

    }
}
