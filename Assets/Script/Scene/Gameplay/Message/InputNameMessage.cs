using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShooter.Scene.MainMenu.InputName
{
    public struct InputNameMessage
    {
        public string PlayerName { get; private set; }

        public InputNameMessage(string s)
        {
            PlayerName = s;
        }
    }

}