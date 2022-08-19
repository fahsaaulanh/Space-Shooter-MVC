using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.Score
{
    public class ScoreController : ObjectController<ScoreController, ScoreView>
    {
        public void ShowScore(int score)
        {

            Debug.Log(score);
            _view.ShowScore(score);
        }
    }
}