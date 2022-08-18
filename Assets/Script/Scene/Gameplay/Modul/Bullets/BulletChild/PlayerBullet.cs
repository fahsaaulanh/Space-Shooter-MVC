using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Scene.Gameplay.Bullet
{
    public class PlayerBullet : BulletController
    {
        public override void BulletCollide(Collider2D col)
        {
            if (col.CompareTag("Enemy"))
            {
                col.gameObject.SetActive(false);
            }
            else if (col.CompareTag("PowerUp"))
            {
                col.gameObject.SetActive(false);
            }
            else if (col.CompareTag("EndLine"))
            {

            }
            else return;
        }
    }
}