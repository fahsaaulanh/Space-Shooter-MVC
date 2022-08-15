using Agate.MVC.Base;
using System;
using UnityEngine;

namespace SpaceShooter.Scene.MainMenu.LeaderBoard
{
    public class LeaderBoardController : ObjectController<LeaderBoardController, LeaderBoardModel, ILeaderBoardModel, LeaderBoardView>
    {
        public LeaderBoardController()
        {
            _model.SetData("Data Leader Board");
        }
    }
}
