using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.Bullet
{
    public class BulletConnector : BaseConnector
    {
        private BulletsPoolController _bulletsPool;

        protected override void Connect()
        {
            Subscribe<ShootMessage>(Shoot);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ShootMessage>(Shoot);
        }

        private void Shoot(ShootMessage message)
        {
            _bulletsPool.SpawnBullet(message.Position, message.SpawnerPosition, message.Shooter);
        }
    }
}
