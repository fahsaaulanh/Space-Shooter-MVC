using Agate.MVC.Base;
using SpaceShooter.Scene.Gameplay.Player;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        public PlayerView player { get { return _playerView; } }

        [SerializeField]
        private PlayerView _playerView;
    }
}