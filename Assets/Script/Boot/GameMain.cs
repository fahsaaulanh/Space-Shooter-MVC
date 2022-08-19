using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using SpaceShooter.SaveData;
using SpaceShooter.CurrentPlayer;

namespace SpaceShooter.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return new IConnector[]
            {
                new SaveConnector(),
                new CurrentPlayerConnector()
            };
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]
            {
                new SaveDataController(),
                new CurrentPlayerController()
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
