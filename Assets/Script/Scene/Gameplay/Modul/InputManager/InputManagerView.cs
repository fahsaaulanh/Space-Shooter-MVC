using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceShooter.Scene.Gameplay.InputManager
{
    public class InputManagerView : BaseView
    {
        private UnityAction _action;
        private UnityAction _OnMoveRight;
        private UnityAction _OnMoveLeft;

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _action?.Invoke();
            }
            if (Input.GetKey(KeyCode.D))
            {

                _OnMoveRight?.Invoke();
            }
            if(Input.GetKey(KeyCode.A))
            {
                _OnMoveLeft?.Invoke();
            }
        }

        public void SetCallbacks(UnityAction onMoveRightPlayer)
        {
            _OnMoveRight = onMoveRightPlayer;
            
        }

        public void InitView(UnityAction action, UnityAction onMoveLeftPlayer)//, UnityAction OnMovePlayer)
        {
            _action = action;
            _OnMoveLeft = onMoveLeftPlayer;
        }
    }
}
