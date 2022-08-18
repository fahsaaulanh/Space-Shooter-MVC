using UnityEngine.Events;

namespace SpaceShooter.CurrentPlayer
{
    public struct SetCurrentPlayerScoreMessage
    {
        public int Score { get; private set; }

        public SetCurrentPlayerScoreMessage(int score)
        {
            Score = score;
        }
    }
}
