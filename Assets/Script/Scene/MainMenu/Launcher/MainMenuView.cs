using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using SpaceShooter.Scene.MainMenu.LeaderBoard;

namespace SpaceShooter.Scene.MainMenu
{
    public class MainMenuView : BaseSceneView
    {
        public LeaderBoardView LeaderBoard {get {return _leaderBoard;}}

        [SerializeField]
        private Button _play;
        [SerializeField]
        private LeaderBoardView _leaderBoard;

        public void Init(UnityAction onPlay)
        {
            _play.onClick.RemoveAllListeners();
            _play.onClick.AddListener(onPlay);
        }
       
    }
}
