using UnityEngine;

namespace SpaceShooter.Scene.Gameplay
{
    public struct UpdateUiScoreMessage
    {
        public int Score { get; private set; }

        public UpdateUiScoreMessage (int score)
        {
            Score = score;
        }
    }
}
