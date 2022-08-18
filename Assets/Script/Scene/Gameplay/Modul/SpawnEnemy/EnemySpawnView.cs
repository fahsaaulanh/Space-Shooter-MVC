using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.SpawnEnemy
{
    
    public class EnemySpawnView : ObjectView<IEnemySpawnModel>
    {
        [SerializeField] public GameObject _enemyTamplate;
        [SerializeField] public Vector2 _offset = new Vector2(2.5f, 2.52f);
        [SerializeField] public Vector2 _startPosition = new Vector2(-5f, 3.62f);
        [SerializeField] public Transform SpawnEnemyPosition;
        public List<GameObject> _enemyList;

        protected override void InitRenderModel(IEnemySpawnModel model)
        {
           
        }

        protected override void UpdateRenderModel(IEnemySpawnModel model)
        {
            
        }

        void Start()
        {
            
          

        }

        void Update()
        {
            
        }

      
    }
}