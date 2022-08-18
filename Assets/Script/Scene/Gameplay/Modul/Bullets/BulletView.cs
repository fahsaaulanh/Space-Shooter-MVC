using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceShooter.Scene.Gameplay.Bullet
{
    public class BulletView : BaseView
    {
        private UnityAction<Collider2D> onCollide;
        private Rigidbody2D rb;


        public void Launch(Vector2 pos, Vector2 spawnerPos)
        {
            transform.position = new Vector3(pos.x, pos.y, transform.position.z);
            rb.velocity = (pos - spawnerPos) * 5;
        }

        public void InitObject(UnityAction<Collider2D> action)
        {
            onCollide = action;
            rb = GetComponent<Rigidbody2D>();
            DeAktive();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            onCollide(collision);
            DeAktive();
        }

        private void DeAktive()
        {
            rb.velocity = Vector2.zero;
            gameObject.SetActive(false);
        }
    }
}
