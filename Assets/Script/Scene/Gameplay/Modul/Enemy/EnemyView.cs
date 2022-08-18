using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShooter.Scene.Gameplay.Enemy
{
    public class EnemyView : ObjectView<IEnemyModel>
    {
        protected override void InitRenderModel(IEnemyModel model)
        {
           
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            
        }

        void Start()
        {
           
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                StartCoroutine(EnemyMovingLeft());
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                StartCoroutine(EnemyMovingRight());
            }
        }

        IEnumerator EnemyMovingLeft ()
        {
            for(int a = 0;  a < 2; a++)
            {

                for (int i = 0; i < 10; i++)
                {
                    transform.localPosition += Vector3.left * 0.005f;
                    yield return new WaitForSeconds(1);
                }
                transform.localPosition += Vector3.down * 0.005f;
            }
            
        }

        IEnumerator EnemyMovingRight()
        {
            for (int a = 0; a < 2; a++)
            {

                for (int i = 0; i < 10; i++)
                {
                    transform.localPosition += Vector3.right * 0.005f;
                    yield return new WaitForSeconds(1);
                }
                transform.localPosition += Vector3.down * 0.005f;
            }

        }
    }
}
