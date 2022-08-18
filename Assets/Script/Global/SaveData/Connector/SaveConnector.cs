using Agate.MVC.Base;

namespace SpaceShooter.SaveData
{
    public class SaveConnector : BaseConnector
    {
        private SaveDataController _saveData;

        protected override void Connect()
        {
            Subscribe<SaveDataMessage>(SaveDataToStorage);
            Subscribe<ComparePlayerMessage>(CompareMessage);
            Subscribe<AskSaveDataMessage>(GetSaveData);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SaveDataMessage>(SaveDataToStorage);
            Unsubscribe<ComparePlayerMessage>(CompareMessage);
            Unsubscribe<AskSaveDataMessage>(GetSaveData);
        }

        private void SaveDataToStorage(SaveDataMessage message)
        {
            _saveData.SaveToStorage();
        }

        private void GetSaveData(AskSaveDataMessage message)
        {
            _saveData.GetDataPlayer(message.Value);
        }

        private void CompareMessage(ComparePlayerMessage message)
        {
            _saveData.CompareScorePlayer(message.Value);
        }
    }
}
