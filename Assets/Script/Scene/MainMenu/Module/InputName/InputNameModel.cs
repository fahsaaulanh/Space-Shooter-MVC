using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Scene.MainMenu.InputName
{
    public interface IInputNameModel : IBaseModel
    {
        public string PlayerName { get; }
    }

    public class InputNameModel : BaseModel, IInputNameModel
    {
        public string PlayerName { get; private set; }

        public void SetData(string s)
        {
            PlayerName = s;
        }
    }
}
