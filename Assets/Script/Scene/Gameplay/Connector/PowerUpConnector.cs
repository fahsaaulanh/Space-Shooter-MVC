using Agate.MVC.Base;

namespace SpaceShooter.Scene.Gameplay.PowerUp
{
    public class PowerUpConnector : BaseConnector
    {
        private PowerUpController _powerUp;

        protected override void Connect()
        {
            Subscribe<PowerUpHitMessage>(Active);
        }

        protected override void Disconnect()
        {
            Unsubscribe<PowerUpHitMessage>(Active);
        }

        private void Active(PowerUpHitMessage message)
        {
            _powerUp.Aktive();
        }
    }
}
