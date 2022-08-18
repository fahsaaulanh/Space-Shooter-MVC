using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceShooter.Scene.Gameplay.InputManager
{
    public class InputManagerView : BaseView
    {
        private UnityAction _action;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _action();
            }
        }

        public void InitView(UnityAction action)
        {
            _action = action;
        }
    }
}
