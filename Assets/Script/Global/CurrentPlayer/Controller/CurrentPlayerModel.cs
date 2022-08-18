using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShooter.CurrentPlayer
{
    public interface ICurrentPlayerModel : IBaseModel
    {
        public DataPlayer CurrentPlayer { get; }
    }

    public class CurrentPlayerModel : BaseModel, ICurrentPlayerModel
    {
        public DataPlayer CurrentPlayer { get; private set; }

        public void SetDataPlayer(DataPlayer data)
        {
            CurrentPlayer = data;
        }

        public void SetScorePlayer(int score)
        {
            CurrentPlayer._score = score;
        }
    }
}
