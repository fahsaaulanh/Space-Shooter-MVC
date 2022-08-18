using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShooter.Scene.Gameplay.Message;

namespace SpaceShooter.Scene.Gameplay.Player
{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, IPlayerModel, PlayerView>
    { 
        public void OnMovePlayer(OnMovePlayer message)
        {
            _view.transform.localPosition += Vector3.right * _model.speed;
        }
    }
}
