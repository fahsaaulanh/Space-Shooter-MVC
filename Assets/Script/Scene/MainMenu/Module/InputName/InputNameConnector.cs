using Agate.MVC.Base;
using UnityEngine;
using SpaceShooter.Scene.Gameplay.Message;
using SpaceShooter.CurrentPlayer;

namespace SpaceShooter.Scene.MainMenu.InputName
{
    public class InputNameConnector : BaseConnector
    {
        private InputNameController _inputController;

        protected override void Connect()
        {
            Subscribe<GetPlayerMessage>(GetPlayer);
        }

        protected override void Disconnect()
        {
            Unsubscribe<GetPlayerMessage>(GetPlayer);
        }

        private void GetPlayer(GetPlayerMessage message)
        {
            _inputController.OpenInputPanel(message.Player);
        }
    }
}