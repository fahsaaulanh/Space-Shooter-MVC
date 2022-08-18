using Agate.MVC.Base;
using UnityEngine;
using SpaceShooter.Scene.Gameplay.Message;

namespace SpaceShooter.Scene.Gameplay.Player
{
    public class PlayerConnector : BaseConnector
    {
        private PlayerController _playerController;
        protected override void Connect()
        {
            Subscribe<OnMovePlayer>(_playerController.OnMovePlayer);
        }

        protected override void Disconnect()
        {
            Unsubscribe<OnMovePlayer>(_playerController.OnMovePlayer);
        }
    }
}