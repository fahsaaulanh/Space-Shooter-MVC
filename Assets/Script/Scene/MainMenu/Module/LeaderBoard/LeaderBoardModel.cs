using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Scene.MainMenu.LeaderBoard
{
    public interface ILeaderBoardModel : IBaseModel
    {
        public string [] Data { get; }
    }

    public class LeaderBoardModel : BaseModel, ILeaderBoardModel
    {
        public string [] Data { get; private set; }

        public void SetData(string [] s)
        {
            Data = s;
            Debug.Log(s);
            SetDataAsDirty();
        }
    }
}
