using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.SpawnEnemy
{
    
    public class EnemySpawnView : ObjectView<IEnemySpawnModel>
    {
        [SerializeField] private GameObject _enemyTamplate;
        [SerializeField] private Vector2 _offset = new Vector2(2.5f, 2.52f);
        [SerializeField] private Vector2 _startPosition = new Vector2(-5f, 3.62f);
        [SerializeField] private Transform SpawnEnemyPosition;
        public List<GameObject> _enemyList;

        protected override void InitRenderModel(IEnemySpawnModel model)
        {
            
        }

        protected override void UpdateRenderModel(IEnemySpawnModel model)
        {
            
        }

        void Start()
        {
            
            SpawnEnemyMesh(4, 4, _startPosition, _offset);
            MoveEnemy(4, 4, _startPosition, _offset);

        }

        void Update()
        {
            
        }

        private void SpawnEnemyMesh(int columns, int rows, Vector2 pos, Vector2 offset)
        {
            for (int col = 0; col < columns ; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    Debug.Log("tes col row " + row + col);
                    var tempEnemy = (GameObject)Instantiate(_enemyTamplate, SpawnEnemyPosition.position, _enemyTamplate.transform.rotation);
                    tempEnemy.name = tempEnemy.name + 'c' + col + 'r' + row;
                    tempEnemy.SetActive(true);
                    _enemyList.Add(tempEnemy);
                }
            }
        }

        public void MoveEnemy (int columns, int rows, Vector2 pos, Vector2 offset)
        {
            var index = 0;
            for (int col = 0; col < columns; col++)
            {
                for(int row = 0; row < rows; row++)
                {
                    Debug.Log("tes col row " + row + col);
                    var targetPosition = new Vector3((pos.x + (offset.x * row)), (pos.y - (offset.y * col)), 0.0f);
                    StartCoroutine(MoveToPosition(targetPosition, _enemyList[index]));
                    index++;
                }
            }
        }

        private IEnumerator MoveToPosition(Vector3 target, GameObject obj)
        {
            var randomDis = 2;
            while(obj.transform.position != target )
            {
                obj.transform.position = Vector3.MoveTowards(obj.transform.position, target, randomDis * Time.deltaTime);

            }
            yield return 0;
        }
    }
}