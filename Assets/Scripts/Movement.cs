using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float delay;
    public Vector2 offset;
    
    public void FixedUpdate()
    {
        StartCoroutine(Move());
        if(transform.position.y<-10) Destroy(gameObject);
    }

    IEnumerator Move()
    {
        
        yield return new WaitForSeconds(delay);
        transform.Translate(offset*speed*Time.fixedDeltaTime);
    }
}
