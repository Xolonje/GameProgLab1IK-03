using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public Vector2 direction = new Vector2(0,1);
    public float speed = 10;
    public Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1);
    }

    void Update()
    {  
        velocity = direction * speed;
        Vector2 pos = transform.position;
        pos += velocity * Time.deltaTime;
        transform.position = pos;
    }

    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Player player = GameObject.Find("Player").GetComponent<Player>();
        Debug.Log(c.name);
        Enemy enemy = c.GetComponent<Enemy>();
        if(enemy!=null)
        {
            enemy.hit(player.Power);
            player.Score+=200;
            Destroy(gameObject);
        } 
    }

}
