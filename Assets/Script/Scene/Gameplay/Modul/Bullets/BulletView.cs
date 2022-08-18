using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceShooter.Scene.Gameplay.Bullet
{
    public class BulletView : BaseView
    {
        private UnityAction<Collider2D> _onCollide;
        private Rigidbody2D _rb;


        public void Launch(Vector2 pos, Vector2 spawnerPos)
        {
            gameObject.SetActive(true);
            transform.position = new Vector3(pos.x, pos.y, transform.position.z);
            _rb.velocity = (pos - spawnerPos) * 5;
        }

        public void InitObject(UnityAction<Collider2D> onCollide)
        {
            _onCollide = onCollide;
            _rb = GetComponent<Rigidbody2D>();
            DeAktive();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            _onCollide(collision);
            DeAktive();
        }

        private void DeAktive()
        {
            _rb.velocity = Vector2.zero;
            gameObject.SetActive(false);
        }
    }
}
