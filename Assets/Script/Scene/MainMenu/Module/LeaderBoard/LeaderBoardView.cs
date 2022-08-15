using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace SpaceShooter.Scene.MainMenu.LeaderBoard
{
    public class LeaderBoardView : ObjectView<ILeaderBoardModel>
    {
        [SerializeField] private Text _testLeaderboard;
  
        protected override void InitRenderModel(ILeaderBoardModel model)
        {
            _testLeaderboard.text = " ";
            foreach (string data in model.Data)
            {
                _testLeaderboard.text += "\n" + data;
                
            }
        }

        protected override void UpdateRenderModel(ILeaderBoardModel model)
        {
          
         
        }
    }
}
