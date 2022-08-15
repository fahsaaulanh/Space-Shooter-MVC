using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace SpaceShooter.Scene.MainMenu.LeaderBoard
{
    public class LeaderBoardView : ObjectView<ILeaderBoardModel>
    {
        protected override void InitRenderModel(ILeaderBoardModel model)
        {
            transform.GetChild(0).GetComponent<Text>().text = model.Data;
        }

        protected override void UpdateRenderModel(ILeaderBoardModel model)
        {
            transform.GetChild(0).GetComponent<Text>().text = model.Data;
        }
    }
}
