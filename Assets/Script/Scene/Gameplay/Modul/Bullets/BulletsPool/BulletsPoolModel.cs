using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceShooter.Scene.Gameplay.Bullet
{
    public interface IBulletsPool : IBaseModel
    {
        public List<BulletController> EPool { get; }
        public List<BulletController> PPool { get; }
    }

    public class BulletsPoolModel : BaseModel, IBulletsPool
    {
        public List<BulletController> EPool { get; private set; }

        public List<BulletController> PPool { get; private set; }

        public void InitPool(List<BulletController> pPool, List<BulletController> ePool)
        {
            PPool = pPool;
            EPool = ePool;
        }
    }
}
