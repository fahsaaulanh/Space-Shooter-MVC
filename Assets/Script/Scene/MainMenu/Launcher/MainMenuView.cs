using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShooter.Boot;
using SpaceShooter.Scene.MainMenu.LeaderBoard;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SpaceShooter.Scene.MainMenu
{
    public class MainMenuView : BaseSceneView
    {
        public LeaderBoardView LeaderBoard { get { return _leaderBoardView; } }

        [SerializeField] private Button _playButton;
        [SerializeField] private LeaderBoardView _leaderBoardView;

        public void Init(UnityAction action)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(action);
        }
    }
}
