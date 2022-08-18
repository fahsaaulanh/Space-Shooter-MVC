using Agate.MVC.Base;
using SpaceShooter.Scene.Gameplay.Timer;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace SpaceShooter.Scene.Gameplay.Score
{
    public class ScoreView : BaseView
    {
        [SerializeField] private Text _scoreUI;
        public void ShowScore (int i)
        {
            _scoreUI.text = "Score :" + i;
        }
    }
}
