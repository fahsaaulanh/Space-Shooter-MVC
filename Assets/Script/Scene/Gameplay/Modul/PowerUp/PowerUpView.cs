using Agate.MVC.Base;
using SpaceShooter.Scene.Gameplay.Timer;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceShooter.Scene.Gameplay.PowerUp
{
    public class PowerUpView : BaseView
    {
        public PowerUpController Controller { get; private set; }

        private UnityAction _updateTime;
        public void InitView(PowerUpController controller, UnityAction action)
        {
            Controller = controller;
            _updateTime = action;
        }

        private void Update()
        {
            _updateTime?.Invoke();
        }
    }
}
