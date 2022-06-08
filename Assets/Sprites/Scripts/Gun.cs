using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Bullet bullet;
    Vector2 direction;
    void Start()
    {
        direction = (transform.localRotation*Vector2.up).normalized;
    }

    public void Shoot()
    {
        GameObject b = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
        Bullet B = b.GetComponent<Bullet>();
        B.direction = direction;
    }
}
