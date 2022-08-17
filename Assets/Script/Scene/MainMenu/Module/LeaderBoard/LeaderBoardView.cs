using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace SpaceShooter.Scene.MainMenu.LeaderBoard
{
    public class LeaderBoardView : BaseView
    {
        [SerializeField] private Text leaderBoardUI;

        public void UpdateLeaderBoard(string text)
        {
            leaderBoardUI.text = text;
        }
    }
}
