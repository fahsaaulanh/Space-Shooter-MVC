using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShooter.Scene.Gameplay.Enemy
{
   public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView>
    {
        public void Init(EnemyView view)
        {
            SetView(view);
            _view.StartCoroutine(EnemyMovingLeft());
        }

        IEnumerator EnemyMovingLeft()
        {
            for (int a = 0; a < 2; a++)
            {

                for (int i = 0; i < 10; i++)
                {
                    _view.transform.localPosition += Vector3.left * 0.15f;
                    yield return new WaitForSeconds(0.5f);
                }
                _view.transform.localPosition += Vector3.down * 0.15f;
                _view.StartCoroutine(EnemyMovingRight());
            }

        }


        IEnumerator EnemyMovingRight()
        {
            for (int a = 0; a < 2; a++)
            {
                for (int i = 0; i < 10; i++)
                {
                    _view.transform.localPosition += Vector3.right * 0.15f;
                    yield return new WaitForSeconds(0.5f);
                }
                _view.transform.localPosition += Vector3.down * 0.15f;
                _view.StartCoroutine(EnemyMovingLeft());
            }

        }
    }
}