using UnityEngine;

public class EvilEnemy : MonoBehaviour
{
    public float Health;
    public void Damage()
    {
        Health = Health - 1;
        if (Health < 0)
        {
            Destroy(gameObject);
        }
    }
}
