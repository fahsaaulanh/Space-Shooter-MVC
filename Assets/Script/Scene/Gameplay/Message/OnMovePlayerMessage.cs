using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShooter.Scene.Gameplay.Message
{
   
    public struct OnMoveRight 
    { 
        public float Speed { get; private set; }

        public OnMoveRight(float s)
        {
            Speed = s;
        }

    }

    public struct OnMoveLeft 
    {
        public float Speed { get; private set; }
        public OnMoveLeft(float s)
        {
            Speed = s;
        }
    }
}