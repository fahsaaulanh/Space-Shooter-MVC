using Agate.MVC.Base;
using SpaceShooter.Scene.Gameplay.Timer;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.PowerUp
{
    public class PowerUpController : ObjectController<PowerUpController, TimerModel, PowerUpView>
    {
        public void InitController(PowerUpView view)
        {
            SetView(view);
            _view.InitView(this, UpdateTimer);
        }

        private void Spawn()
        {
            if (!_view.gameObject.activeInHierarchy)
            {
                _view.gameObject.SetActive(true);
            }
        }

        public void Aktive()
        {
            _view.gameObject.SetActive(false);
            Publish(new PowerUpActiveMessage(true));
            _model.ResetTimer(0, 10, Deaktive);
        }

        public void Deaktive()
        {
            Publish(new PowerUpActiveMessage(false));
            _model.ResetTimer(0, Random.Range(5, 16), Spawn);
        }

        private void UpdateTimer()
        {
            if (!_model.Active) return;

            _model.UpdateCurrentTime(_model.CurrentTime + Time.deltaTime);
            if (_model.CurrentTime >= _model.CompleteTime)
            {
                _model.OnComplete();
            }
        }
    }
}