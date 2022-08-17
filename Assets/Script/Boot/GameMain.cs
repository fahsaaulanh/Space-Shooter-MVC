using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using SpaceShooter.SaveData;

namespace SpaceShooter.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        private SaveDataController _saveDataController;

        protected override IConnector[] GetConnectors()
        {
            return new IConnector[]
            {
                new SaveConnector()
            };
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]
            {
                new SaveDataController()
            };
        }

        protected override IEnumerator StartInit()
        {
            CreateEventSystem();
            yield return null;
        }

        private void CreateEventSystem()
        {
            GameObject obj = new GameObject("Event System");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>();
            GameObject.DontDestroyOnLoad(obj);
        }
    }
}
