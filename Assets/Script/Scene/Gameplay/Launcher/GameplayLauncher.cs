using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShooter.Boot;
using SpaceShooter.Scene.Gameplay.Player;

namespace SpaceShooter.Scene.Gameplay
{

    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";
        private PlayerController _playerController;

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                 new PlayerController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _playerController.SetView(_view.player);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    
    }
}