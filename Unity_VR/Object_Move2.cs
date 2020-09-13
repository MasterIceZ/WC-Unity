using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Move2 : MonoBehaviour
{
    public float Speed;
    void Update()
    {
        transform.Translate(0,0,Speed*-1*Time.deltaTime);
    }
}
