using System;

namespace Assets.Source.CodeBase
{
    public class Observable<T>
    {
        private T _value;

        public T Value
        {
            get => _value;

            set
            {
                _value = value;
                ValueChanged?.Invoke(_value);
            }
        }

        public event Action<T> ValueChanged;

        public Observable(T value)
        {
            Value = value;
        }   
    }
}
