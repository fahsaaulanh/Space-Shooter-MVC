using Agate.MVC.Base;

namespace SpaceShooter.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        protected override string SplashScene { get { return "SplashScene";} }
    }
}
