using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShooter.Boot;
using SpaceShooter.Scene.MainMenu.LeaderBoard;
using System.Collections;
using UnityEngine;

namespace SpaceShooter.Scene.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        public override string SceneName { get { return "MainMenu"; } }

        //private LeaderBoardController _leaderBoard;

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                new LeaderBoardController(),
            };
        }

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            Debug.Log(_view.name);
            //_view.Init(ClickPlay);
            //_leaderBoard.SetView(_view.LeaderBoard);
            /*_view.Init(SceneName, BackToHome, Restart);
            _gold.SetView(_view.Gold);
            _tavern.SetView(_view.Tavern);*/
            yield return null;
        }

        private void ClickPlay()
        {
            SceneLoader.Instance.LoadScene("GamePlay");
        }

        /*private void Restart()
        {
            SceneLoader.Instance.RestartScene();
        }*/
    }
}
