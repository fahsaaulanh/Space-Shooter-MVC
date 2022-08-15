using Agate.MVC.Base;
using System.Collections.Generic;

namespace SpaceShooter.Scene.MainMenu.LeaderBoard
{
    public interface ILeaderBoardModel : IBaseModel
    {
        public string Data { get; }
    }

    public class LeaderBoardModel : BaseModel, ILeaderBoardModel
    {
        public string Data { get; private set; }

        public void SetDara(string s)
        {
            Data = s;
        }
    }
}
