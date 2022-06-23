using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    Gun[] guns;
    public float Speed = 8;
    public int Max = 16;
    public int Score = 0;
    public float fireDelta = 0.5F;
    private float nextFire = 0.5F;
    public int Power = 1; 
    private float myTime = 0.0F;
    public int Lives = 4;
    public Text t1;
    public Text t2;
    public Text t3;
    void Start()
    {
        guns = transform.GetComponentsInChildren<Gun>();

    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(x,y).normalized;
        if(!Input.GetButton("Slow")) Move(dir,Speed);
        else Move(dir, Speed/3);
        myTime = myTime + Time.deltaTime;
        if(Input.GetButton("Fire1") && myTime > nextFire) 
        {
            nextFire = myTime + fireDelta;
            foreach (Gun gun in guns) gun.Shoot();
            nextFire = nextFire - myTime;
            myTime = 0.0F;
        }
        t1.text = "Score: " + Score.ToString();
        t2.text = "Power:" + Power.ToString();
        t3.text = "Lives:" + Lives.ToString();
        if(Lives == 0) SceneManager.LoadScene("GameOver");
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