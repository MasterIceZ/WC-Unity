using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning2 : MonoBehaviour
{
    public float Spinner;
    void Start()
    {
        Spinner = Random.Range(-2,2);    
    }

    void Update()
    {
        transform.Rotate(Spinner,Spinner,Spinner);
    }
}
