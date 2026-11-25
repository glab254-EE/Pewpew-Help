using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float Speed;
    public GameObject Bullet;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(Bullet,transform.position,transform.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = transform.forward * Speed;
        }
    }
}
