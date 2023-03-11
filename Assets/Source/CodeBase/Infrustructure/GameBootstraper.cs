using Assets.Source.CodeBase.Infrustructure.Services;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Source.CodeBase.Infrustructure
{
    public class GameBootstraper : MonoBehaviour
    {
        private Game _game;
        private Updater _updater;

        private void Awake()
        {
            _updater = new Updater();
            _game = new Game(_updater);
        }

        private void Update()
        {
            _updater.Update(Time.deltaTime);
        }
    }

    public class Updater : IUpdater
    {
        private List<IUpdatable> _updatables = new List<IUpdatable>();

        public void AddListener(IUpdatable updatable)
        {
            if(_updatables.Contains(updatable) == false)
                _updatables.Add(updatable);
        }

        public void RemoveListener(IUpdatable updatable)
        {
            if(_updatables.Contains(updatable))
                _updatables.Remove(updatable);
        }

        public void Update(float tick) => 
            _updatables.ForEach(updatable => updatable.Update(tick));
    }

    public interface IUpdater : IService
    {
        void Update(float tick);
        void AddListener(IUpdatable updatable);
        void RemoveListener(IUpdatable updatable);
    }
}
