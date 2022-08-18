using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.PowerUp
{
    public class PowerUpController : ObjectController<PowerUpController, PowerUpView>
    {
        public void InitController(PowerUpView view)
        {
            SetView(view);
        }

        private void Spawn()
        {
            if (_view.gameObject.activeInHierarchy)
            {

            }
        }
    }
}