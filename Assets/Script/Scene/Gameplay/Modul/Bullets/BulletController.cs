using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.Bullet
{
    public abstract class BulletController : ObjectController<BulletController, BulletView>
    {
        public bool ObjActive { get => _view.gameObject.activeInHierarchy; }

        public void InitController(BulletView view)
        {
            SetView(view);
            _view.InitObject(BulletCollide);
        }

        public void SpawnBullet(Vector2 pos, Vector2 spawnerPos)
        {
            _view.Launch(pos, spawnerPos);
        }

        public abstract void BulletCollide(Collider2D col);
    }
}