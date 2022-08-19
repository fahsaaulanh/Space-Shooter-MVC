using Agate.MVC.Base;
using SpaceShooter.Scene.Gameplay.Player;
using SpaceShooter.Scene.Gameplay.SpawnEnemy;
using SpaceShooter.Scene.Gameplay.Enemy;
using SpaceShooter.Scene.Gameplay.InputManager;
using SpaceShooter.Scene.Gameplay.Bullet;
using SpaceShooter.Scene.Gameplay.Score;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        public PlayerView player { get { return _playerView; } }
        public EnemySpawnView enemySpawn { get { return _enemySpawnView; } }
        public EnemyView enemyView { get { return _enemyView; } }
        public InputManagerView inputView { get { return _inputView; } }
        public BulletsPoolView PoolBulletView { get { return _poolBulletsView; } }
        public ScoreView ScoreView { get { return _scoreView; } }

        [SerializeField]
        private PlayerView _playerView;
        [SerializeField]
        private EnemySpawnView _enemySpawnView;
        [SerializeField]
        private EnemyView _enemyView;
        [SerializeField]
        private InputManagerView _inputView;
        [SerializeField]
        private BulletsPoolView _poolBulletsView;
        [SerializeField]
        private ScoreView _scoreView;

    }
}