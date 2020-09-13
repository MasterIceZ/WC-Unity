using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Move3 : MonoBehaviour
{
    public float Speed;
    void Start()
    {
        Speed = Random.Range(1,10);
    }
    void Update()
    {
        transform.Translate(0,0,Speed*-1*Time.deltaTime);
    }
}
