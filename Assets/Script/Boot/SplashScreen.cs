using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;

namespace SpaceShooter.Boot
{
    public class SplashScreen : BaseSplash<SplashScreen>
    {
        protected override IMain GetMain()
        {
            return GameMain.Instance;
        }

        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }
    }
}
