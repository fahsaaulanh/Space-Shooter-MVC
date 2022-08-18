using Agate.MVC.Base;

namespace SpaceShooter.CurrentPlayer
{
    public class CurrentPlayerConnector : BaseConnector
    {
        private CurrentPlayerController _playerController;

        protected override void Connect()
        {
            Subscribe<CreatePlayerMessage>(SetPlayer);
            Subscribe<AskCurrentPlayerMessage>(GetPlayer);
            Subscribe<SetCurrentPlayerScoreMessage>(SetPlayerScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<CreatePlayerMessage>(SetPlayer);
            Unsubscribe<AskCurrentPlayerMessage>(GetPlayer);
            Unsubscribe<SetCurrentPlayerScoreMessage>(SetPlayerScore);
        }

        private void SetPlayer(CreatePlayerMessage message)
        {
            _playerController.SetPlayer(message.PlayerName);
        }

        private void GetPlayer(AskCurrentPlayerMessage message)
        {
            _playerController.GetPlayer();
        }

        private void SetPlayerScore(SetCurrentPlayerScoreMessage message)
        {
            _playerController.SetScoreComparePlayer(message.Score);
        }
    }
}
