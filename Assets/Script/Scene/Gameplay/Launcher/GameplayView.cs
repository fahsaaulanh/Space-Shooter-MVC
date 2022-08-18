using Agate.MVC.Base;
using SpaceShooter.Scene.Gameplay.Player;
using SpaceShooter.Scene.Gameplay.SpawnEnemy;
using SpaceShooter.Scene.Gameplay.InputManager;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        public PlayerView player { get { return _playerView; } }
        public EnemySpawnView enemySpawn { get { return _enemySpawnView; } }
        public InputManagerView inputView { get { return _inputView; } }

        [SerializeField]
        private PlayerView _playerView;
        [SerializeField]
        private EnemySpawnView _enemySpawnView;
        [SerializeField]
        private InputManagerView _inputView;

    }
}