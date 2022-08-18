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

        public float speed = 0.005f;

        public void IncreaseScore(int value)
        {
            Score += value;
        }
    }
}