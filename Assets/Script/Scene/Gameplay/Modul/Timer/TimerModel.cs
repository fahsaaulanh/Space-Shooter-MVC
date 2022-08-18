using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine.Events;

namespace SpaceShooter.Scene.Gameplay.Timer
{
    public interface ITimerModel : IBaseModel
    {
        public float CurrentTime { get; }
        public float CompleteTime { get; }
        public bool Active { get; }
    }

    public class TimerModel : BaseModel, ITimerModel
    {
        public float CurrentTime { get; private set; }
        public float CompleteTime { get; private set; }
        public bool Active { get; private set; }

        private UnityAction _onComplete;
        public void ResetTimer(float currentTime, float completeTime, UnityAction action)
        {
            CurrentTime = currentTime;
            CompleteTime = completeTime;
            _onComplete = action;
            Active = true;
        }

        public void UpdateCurrentTime(float currentTime)
        {
            CurrentTime = currentTime;
        }

        public void OnComplete()
        {
            _onComplete();
            Active = false;
        }
    }
}
