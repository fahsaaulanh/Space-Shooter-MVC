using UnityEngine.Events;

namespace SpaceShooter.SaveData
{
    public struct AskSaveDataMessage
    {
        public UnityAction<DataPlayer[]> Value { get; private set; }

        public AskSaveDataMessage(UnityAction<DataPlayer[]> value)
        {
            Value = value;
        }
    }
}
