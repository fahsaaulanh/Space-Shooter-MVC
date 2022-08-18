using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceShooter.Scene.Gameplay.Bullet
{
    public class BulletsPoolView : ObjectView<IBulletsPool>
    {
        public int SizePool { get => size; }
        [SerializeField] private GameObject eBullet;
        [SerializeField] private GameObject pBullet;
        [SerializeField] private int size;


        public GameObject InstantiateEBullet()
        {
            return Instantiate(eBullet, transform);
        }

        public GameObject InstantiatePBullet()
        {
            return Instantiate(pBullet, transform);
        }

        protected override void InitRenderModel(IBulletsPool model)
        {

        }

        protected override void UpdateRenderModel(IBulletsPool model)
        {
            
        }
    }
}
