using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Gun[] guns;

    void Start()
    {
        guns = transform.GetComponentsInChildren<Gun>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(x,y).normalized;
        if(!Input.GetButton("Slow")) Move(dir,8);
        else Move(dir, 2);
        if(Input.GetButton("Fire1")) foreach (Gun gun in guns) gun.Shoot();
        
    }


    void Move(Vector2 direction, float speed)
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
        max.x-= 0.5f;
        min.x+= 0.5f;
        max.y-= 0.5f;
        min.y+= 0.5f;
        Vector2 pos = transform.position;
        pos+= direction*speed*Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);
        transform.position = pos;
    }

}
