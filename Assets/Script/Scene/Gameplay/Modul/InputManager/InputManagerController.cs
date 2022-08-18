using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShooter.Scene.Gameplay.InputManager
{
    public class InputManagerController : ObjectController<InputManagerController, InputManagerView>
    {
        public void InitController(InputManagerView view)
        {
            SetView(view);
            _view.InitView(OnPlayerClick);
        }

        private void OnPlayerClick()
        {
            /*ShootMessage ms = new ShootMessage(,,'P');
            Publish();*/
        }
    }
}
