using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.PowerUp
{
    public struct PowerUpActiveMessage
    {
        public bool Status { get; private set; }

        public PowerUpActiveMessage(bool b)
        {
            Status = b;
        }
    }
}
