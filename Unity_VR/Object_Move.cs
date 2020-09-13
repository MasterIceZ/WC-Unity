using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Move : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0,0,-5*Time.deltaTime);
    }
}
