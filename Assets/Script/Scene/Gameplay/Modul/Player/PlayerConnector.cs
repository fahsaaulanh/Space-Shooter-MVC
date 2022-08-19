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
            _playerController.OnMoveRight(message.Speed);
        }

        public void OnMoveLeft(OnMoveLeft message)
        {
            _playerController.OnMoveLeft(message.Speed);
        }

        private void OnShoot(PlayerClickMessage message)
        {
            _playerController.OnShoot();
        }

        private void OnScore(PlayerGotScore messsage)
        {
            _playerController.GotScore();
        }

        protected override void Connect()
        {
            Subscribe<OnMoveRight>(OnMoveRight);
            Subscribe<OnMoveLeft>(OnMoveLeft);
            Subscribe<PlayerClickMessage>(OnShoot);
            Subscribe<PlayerGotScore>(OnScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<OnMoveRight>(OnMoveRight);
            Unsubscribe<OnMoveLeft>(OnMoveLeft);
            Unsubscribe<PlayerClickMessage>(OnShoot);
            Unsubscribe<PlayerGotScore>(OnScore);
        }
    }
}