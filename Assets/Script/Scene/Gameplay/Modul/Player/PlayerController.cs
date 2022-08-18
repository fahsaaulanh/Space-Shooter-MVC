using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShooter.Scene.Gameplay.Message;

namespace SpaceShooter.Scene.Gameplay.Player
{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, IPlayerModel, PlayerView>
    { 
        public void OnMoveRight()
        {
            _view.transform.localPosition += Vector3.right * _model.speed;
        }

        public void OnMoveLeft()
        {
            _view.transform.localPosition += Vector3.left * _model.speed;
        }

        public void OnShoot()
        {
            Vector2 pos = _view.transform.position;
            Publish(new ShootMessage(pos+Vector2.up, pos, 'P'));
        }

        public void GotScore()
        {
            _model.IncreaseScore(10);
            Publish(new UpdateUiScoreMessage(_model.Score));
        }
    }
}
