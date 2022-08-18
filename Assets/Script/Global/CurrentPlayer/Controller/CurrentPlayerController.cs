using Agate.MVC.Base;
using SpaceShooter.SaveData;
using UnityEngine;

namespace SpaceShooter.CurrentPlayer
{
    public class CurrentPlayerController : DataController<CurrentPlayerController, CurrentPlayerModel>
    {
        public void SetPlayer(string playerName)
        {
            DataPlayer player = new DataPlayer(playerName, 0);
            _model.SetDataPlayer(player);
        }

        public void GetPlayer()
        {
            Publish(new GetPlayerMessage(_model.CurrentPlayer));
        }

        public void SetScoreComparePlayer(int score)
        {
            _model.SetScorePlayer(score);
            Publish(new ComparePlayerMessage(_model.CurrentPlayer));
        }
    }
}
