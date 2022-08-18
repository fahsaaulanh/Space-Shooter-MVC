using Agate.MVC.Base;
using UnityEngine;
using SpaceShooter.Scene.Gameplay.Message;

namespace SpaceShooter.Scene.Gameplay.Player
{
    public class PlayerConnector : BaseConnector
    {
        private PlayerController _playerController;

        public void OnMoveRight(OnMoveRight message)
        {
            _playerController.OnMoveRight();
        }

        public void OnMoveLeft(OnMoveLeft message)
        {
            _playerController.OnMoveLeft();
        }
        protected override void Connect()
        {
            Subscribe<OnMoveRight>(OnMoveRight);
            Subscribe<OnMoveLeft>(OnMoveLeft);
        }

        protected override void Disconnect()
        {
            Unsubscribe<OnMoveRight>(OnMoveRight);
            Unsubscribe<OnMoveLeft>(OnMoveLeft);
        }
    }
}