using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    public float Spinner;
    void Start()
    {
        Spinner = Random.Range(-10,10);    
    }

    void Update()
    {
        transform.Rotate(Spinner,Spinner,0);
    }
}
