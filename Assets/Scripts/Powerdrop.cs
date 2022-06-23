using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerdrop : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D c)
    {
        Debug.Log(c.name);
        Player p = c.GetComponent<Player>();
        if(p!=null)
        {
            p.Power++;
            Destroy(gameObject);
        } 
    }
}
