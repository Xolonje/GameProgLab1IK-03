using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Droplet drop;
    public Powerdrop pow;
    public int hp = 3;
    bool randomBool1;
    bool randomBool2;
    void Start()
    {
        randomBool1 = Random.value>0.5;
        randomBool2 = Random.value>0.5;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Debug.Log(c.name);
        Player enemy = c.GetComponent<Player>();
        if(enemy!=null)
        {
            enemy.Lives--;
        } 
    }

    public void hit(int dmg)
    {
        hp-=dmg;
        if(hp<=0) 
        {
            Destroy(gameObject);
            Debug.Log(randomBool1);
            if(!randomBool1)
            {

            }
            else
            {
                if(!randomBool2)
                {
                    GameObject go = Instantiate(drop.gameObject, transform.position, Quaternion.identity);
                    Droplet d = go.GetComponent<Droplet>();
                }
                else
                {
                    GameObject go = Instantiate(pow.gameObject, transform.position, Quaternion.identity);
                    Powerdrop pd = go.GetComponent<Powerdrop>();
                }
            }
        }
    }
}
