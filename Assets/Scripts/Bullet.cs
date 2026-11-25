using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision == null) return;
        if (collision.gameObject != null && collision.gameObject.TryGetComponent(out EvilEnemy e))
        {
            e.Damage();
            Destroy(gameObject);
        }
    }
}
