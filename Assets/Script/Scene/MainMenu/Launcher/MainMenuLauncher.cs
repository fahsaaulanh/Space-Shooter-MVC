using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShooter.Boot;
using SpaceShooter.Scene.MainMenu.LeaderBoard;
using SpaceShooter.Scene.MainMenu.InputName;
using SpaceShooter.SaveData;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceShooter.Scene.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        public override string SceneName { get { return "MainMenu"; } }

        private LeaderBoardController _leaderBoardController;
        private InputNameController _inputNameController;

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                new LeaderBoardController(),
                new InputNameController()
            };
        }

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new InputNameConnector()
            };
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _view.Init(OnClickPlay);
            _inputNameController.InitController(_view.InputNameView);
            _leaderBoardController.InitController(_view.LeaderBoard);
            yield return null;
        }

        private void OnClickPlay()
        {
            SceneLoader.Instance.LoadScene("Gameplay");
        }

        /*private void Restart()
        {
            SceneLoader.Instance.RestartScene();
        }*/
    }
}
