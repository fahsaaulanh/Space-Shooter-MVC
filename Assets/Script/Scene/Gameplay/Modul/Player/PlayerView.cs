using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.Player
{
    public class PlayerView : ObjectView<IPlayerModel>
    {
        private float speed = 0.005f;
        protected override void InitRenderModel(IPlayerModel model)
        {

        }

        protected override void UpdateRenderModel(IPlayerModel model)
        {

        }

        private void Update()
        {
            
        }

        public void MoveRight()
        {
            transform.localPosition += Vector3.right * speed;
        }

        public void MoveLeft()
        {
            transform.localPosition += Vector3.left * speed;
        }

    }
}