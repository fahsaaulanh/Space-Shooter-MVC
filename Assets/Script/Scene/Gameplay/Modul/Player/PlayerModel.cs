using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShooter.Scene.Gameplay.Player
{
    public interface IPlayerModel : IBaseModel
    {
        public int Score { get; }
    }

    public class PlayerModel : BaseModel, IPlayerModel
    {
        public int Score { get; private set; }
        public int life { get; private set; }
        public Vector2 maxRangeX { get; private set; } = new Vector2(7 , 0);

        public float speed = 0.005f;

        public void IncreaseScore(int value)
        {
            Score += value;
        }
    }
}