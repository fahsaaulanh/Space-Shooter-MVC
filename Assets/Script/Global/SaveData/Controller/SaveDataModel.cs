using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShooter.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        public DataPlayer[] DataPlayer { get; }
    }

    public class SaveDataModel : BaseModel, ISaveDataModel
    {
        public DataPlayer[] DataPlayer { get; private set; }

        public void LoadDataModel(DataPlayer[] data)
        {
            DataPlayer = data;
        }
    }
}
