using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShooter.CurrentPlayer;

namespace SpaceShooter.Scene.Gameplay.Player
{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, IPlayerModel, PlayerView>
    { 
        public void OnMoveRight(float s)
        {
           if(_view.transform.position.x <= _model.maxRangeX.x)
            {
                
                _view.transform.localPosition += Vector3.right * s;
            }
        }

        public void OnMoveLeft(float s)
        {
            if(_view.transform.position.x >= - _model.maxRangeX.x)
            {
                Debug.Log("tes");
                _view.transform.localPosition += Vector3.left * s;
            }
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
