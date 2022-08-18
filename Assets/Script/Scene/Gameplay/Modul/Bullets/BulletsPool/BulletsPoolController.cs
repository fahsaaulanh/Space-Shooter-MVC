using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.Bullet
{
    public class BulletsPoolController : ObjectController<BulletsPoolController, BulletsPoolModel, IBulletsPool, BulletsPoolView>
    {
        public void InitController(BulletsPoolView view)
        {
            SetView(view);
            _model.InitPool(new List<BulletController>(), new List<BulletController>());

            for(int i=0; i<_view.SizePool; i++)
            {
                InstantiateNewOne(_model.PPool, 'P');
                InstantiateNewOne(_model.EPool, 'E');
            }
        }

        public void SpawnBullet(Vector2 pos, Vector2 spawnPos, char shooter)
        {
            SpawnBullet(pos, spawnPos, _model.PPool, shooter);
        }

        private void SpawnBullet(Vector2 pos, Vector2 spawnPos, List<BulletController> bullets, char c)
        {
            foreach (BulletController bullet in bullets)
            {
                if (!bullet.ObjActive)
                {
                    bullet.SpawnBullet(pos, spawnPos);
                    return;
                }

            }

            InstantiateNewOne(bullets, c);
        }

        private void InstantiateNewOne(List<BulletController> bullets, char ID)
        {
            BulletView _bulletView;
            BulletController _newOne;
            switch (ID)
            {
                case 'P':
                    _bulletView = _view.InstantiatePBullet().GetComponent<BulletView>();
                    _newOne = new PlayerBullet();
                    break;
                case 'E':
                    _bulletView = _view.InstantiateEBullet().GetComponent<BulletView>();
                    _newOne = new EnemyBullet();
                    break;
                default:
                    _bulletView = null;
                    _newOne = null;
                    break;
            }

            _newOne.InitController(_bulletView);
        }
    }
}