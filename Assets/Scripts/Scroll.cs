using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Scroll : MonoBehaviour 
{
    public float speed = 4f;
    Vector3 StarPos;
 
    void Start()
    {
        StarPos = transform.position;
    }

    void Update()
    {
        transform.Translate(translation: Vector3.down*speed*Time.deltaTime);
        if(transform.position.y < -95f) transform.position = StarPos;
    }
}