using UnityEngine;

namespace SpaceShooter.Scene.Gameplay
{
    public struct ShootMessage
    {
        public Vector2 Position { get; set; }
        public Vector2 SpawnerPosition { get; set; }
        public char Shooter { get; set; }

        public ShootMessage(Vector2 pos, Vector2 spawnerPos, char shooter)
        {
            Position = pos;
            SpawnerPosition = spawnerPos;
            Shooter = shooter;
        }
    }
}
