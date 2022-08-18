using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceShooter.Scene.Gameplay.Bullet
{
    public class BulletsPoolView : ObjectView<IBulletsPool>
    {
        public int SizePool { get; private set; }
        [SerializeField] private GameObject eBullet;
        [SerializeField] private GameObject pBullet;
        [SerializeField] private int size;


        public GameObject InstantiateEBullet()
        {
            return Instantiate(eBullet);
        }

        public GameObject InstantiatePBullet()
        {
            return Instantiate(pBullet);
        }

        protected override void InitRenderModel(IBulletsPool model)
        {

        }

        protected override void UpdateRenderModel(IBulletsPool model)
        {
            
        }
    }
}
