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
            _view.InitView(OnPlayerClick, OnClickMoveLeft);
        }

        public override void SetView(InputManagerView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickMoveRight);
        }

        private void OnClickMoveRight()
        {
            Publish<OnMoveRight>(new OnMoveRight(0.01f));
        }

        private void OnClickMoveLeft()
        {
            Debug.Log("tes");
            Publish<OnMoveLeft>(new OnMoveLeft(0.01f));
        }

        private void OnPlayerClick()
        {
            Publish(new PlayerClickMessage());
        }
    }
}
