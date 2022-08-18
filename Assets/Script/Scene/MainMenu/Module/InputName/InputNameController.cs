using Agate.MVC.Base;
using SpaceShooter.CurrentPlayer;
using System;
using UnityEngine;

namespace SpaceShooter.Scene.MainMenu.InputName
{
    public class InputNameController : ObjectController<InputNameController, InputNameModel, IInputNameModel, InputNameView>
    {
        public void InitController(InputNameView view)
        {
            SetView(view);
            Publish(new AskCurrentPlayerMessage());
        }

        public void OpenInputPanel(DataPlayer player)
        {
            _view.InitView(EnterName, EnterName);
            _view.gameObject.SetActive(player == null);
        }

        private void EnterName()
        {
            Debug.Log(_model.PlayerName);
            if (string.IsNullOrWhiteSpace(_model.PlayerName)) return;

            Publish(new CreatePlayerMessage(_model.PlayerName));
            _view.gameObject.SetActive(false);
        }

        private void EnterName(string s)
        {
            _model.SetData(s);
        }
    }
}
