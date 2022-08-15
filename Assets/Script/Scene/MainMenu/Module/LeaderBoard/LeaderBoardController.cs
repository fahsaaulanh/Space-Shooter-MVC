using Agate.MVC.Base;
using System;

namespace SpaceShooter.Scene.MainMenu.LeaderBoard
{
    public class LeaderBoardController : ObjectController<LeaderBoardController, LeaderBoardModel, ILeaderBoardModel, LeaderBoardView>
    {
        public LeaderBoardController()
        {
            SetView(_view);
            _model.SetDara("Data Leader Board");
        }
    }
}
