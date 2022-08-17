using UnityEngine.Events;

namespace SpaceShooter.SaveData
{
    public struct ComparePlayerMessage
    {
        public DataPlayer Value { get; private set; }

        public ComparePlayerMessage(DataPlayer value)
        {
            Value = value;
        }
    }
}
