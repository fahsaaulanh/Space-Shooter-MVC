using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.Score
{
    public class ScoreConnector : BaseConnector
    {
        private ScoreController _scoreController;

        protected override void Connect()
        {
            Subscribe<UpdateUiScoreMessage>(ShowScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateUiScoreMessage>(ShowScore);
        }

        private void ShowScore(UpdateUiScoreMessage message)
        {
            _scoreController.ShowScore(message.Score);
        }
    }
}
