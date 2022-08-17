using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.Enemy
{
    public class EnemyView : ObjectView<IEnemyModel>
    {
        [SerializeField] private GameObject tamplateEnemy;
        protected override void InitRenderModel(IEnemyModel model)
        {
            
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            
        }

        private void SpawnEnemy()
        {

        }

        private void SpawnPosition()
        {

        }
    }
}
