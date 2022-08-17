using Agate.MVC.Base;
using SpaceShooter.Scene.Gameplay.Player;
using SpaceShooter.Scene.Gameplay.SpawnEnemy;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        public PlayerView player { get { return _playerView; } }
        public EnemySpawnView enemySpawn { get { return _enemySpawnView; } }

        [SerializeField]
        private PlayerView _playerView;
        [SerializeField]
        private EnemySpawnView _enemySpawnView;

    }
}