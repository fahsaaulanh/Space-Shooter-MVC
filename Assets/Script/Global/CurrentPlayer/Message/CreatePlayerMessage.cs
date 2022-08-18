using UnityEngine.Events;

namespace SpaceShooter.CurrentPlayer
{
    public struct CreatePlayerMessage
    {
        public string PlayerName { get; private set; }

        public CreatePlayerMessage(string value)
        {
            PlayerName = value;
        }
    }
}
