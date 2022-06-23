using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droplet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D c)
    {
        Debug.Log(c.name);
        Player p = c.GetComponent<Player>();
        if(p!=null)
        {
            p.Score+=100;
            Destroy(gameObject);
        } 
    }
}
