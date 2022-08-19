using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShooter.Scene.Gameplay.SpawnEnemy
{
    public class EnemySpawnController : ObjectController<EnemySpawnController, EnemySpawnModel , IEnemySpawnModel, EnemySpawnView>
    {
        public void Init(EnemySpawnView view)
        {
            SetView(view);
            SpawnEnemyMesh(5, 20, _view._startPosition, _view._offset);
            _view.StartCoroutine(moveing());
        }

        private void SpawnEnemyMesh(int columns, int rows, Vector2 pos, Vector2 offset)
        {
            for (int col = 0; col < columns; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    var tempEnemy = GameObject.Instantiate(_view._enemyTamplate, _view.SpawnEnemyPosition.position, Quaternion.identity, _view.SpawnEnemyPosition);
                    tempEnemy.name = tempEnemy.name + 'c' + col + 'r' + row;
                    tempEnemy.SetActive(true);
                    _view._enemyList.Add(tempEnemy);
                }
            }
        }

        IEnumerator moveing()
        {
            

            for (int i = 0; i < 3; i++)
            {
                MoveEnemy(5, 20, _view._startPosition, _view._offset);
                yield return new WaitForSeconds(3);
            }

            foreach (GameObject enemy in _view._enemyList)
            {
                enemy.transform.position = _view._startPosition;
            }

        }


        public void MoveEnemy(int columns, int rows, Vector2 pos, Vector2 offset)
        {
            var index = 0;
            for (int col = 0; col < columns; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    var targetPosition = new Vector3((pos.x + (offset.x * row)), (pos.y - (offset.y * col)), 0.0f);
                    _view.StartCoroutine(MoveToPosition(targetPosition, _view._enemyList[index]));
                    index++;
                }
            }
        }

        
        IEnumerator MoveToPosition(Vector3 target, GameObject obj)
        {
            var randomDis = 5;
            while (obj.transform.position != target)
            {
                obj.transform.position = Vector3.MoveTowards(obj.transform.position, target, randomDis * Time.deltaTime);
                yield return 0;
            }

        }
    }
}