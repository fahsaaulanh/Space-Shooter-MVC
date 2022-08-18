using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShooter.Scene.Gameplay.Message;

namespace SpaceShooter.Scene.Gameplay.InputManager
{
    public class InputManagerController : ObjectController<InputManagerController, InputManagerView>
    {
        public void InitController(InputManagerView view)
        {
            SetView(view);
            _view.InitView(OnPlayerClick);
        }

        public override void SetView(InputManagerView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickMoveRight, OnClickMoveLeft);
        }

        private void OnClickMoveRight()
        {
            Publish<OnMoveRight>(new OnMoveRight());
        }

        private void OnClickMoveLeft()
        {
            Publish<OnMoveLeft>(new OnMoveLeft());
        }

        private void OnPlayerClick()
        {
            Publish(new PlayerClickMessage());
        }
    }
}
