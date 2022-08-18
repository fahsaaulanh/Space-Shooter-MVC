using UnityEngine.Events;

namespace SpaceShooter.CurrentPlayer
{
    public struct GetPlayerMessage
    {
        public DataPlayer Player { get; private set; }

        public GetPlayerMessage(DataPlayer value)
        {
            Player = value;
        }
    }
}
