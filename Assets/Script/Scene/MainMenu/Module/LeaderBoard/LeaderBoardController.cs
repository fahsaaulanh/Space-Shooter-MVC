using Agate.MVC.Base;
using System;

namespace SpaceShooter.Scene.MainMenu.LeaderBoard
{
    public class LeaderBoardController : ObjectController<LeaderBoardController, LeaderBoardModel, ILeaderBoardModel, LeaderBoardView>
    {
        public LeaderBoardController()
        {
            string[] array = new string[] { "array1", "array2", "array3" };
            _model.SetData(array);
        }

    
    }
}
