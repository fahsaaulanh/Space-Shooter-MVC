using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShooter.Boot;
using SpaceShooter.Scene.MainMenu.LeaderBoard;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using SpaceShooter.Scene.MainMenu.InputName;

namespace SpaceShooter.Scene.MainMenu
{
    public class MainMenuView : BaseSceneView
    {
        public LeaderBoardView LeaderBoard { get { return _leaderBoardView; } }
        public InputNameView InputNameView { get { return _inputNameView; } }

        [SerializeField] private LeaderBoardView _leaderBoardView;
        [SerializeField] private InputNameView _inputNameView;

        [SerializeField] private Button _playButton;

        public void Init(UnityAction action)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(action);
        }
    }
}
