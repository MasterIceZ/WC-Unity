using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    public float Scaler;
    void Start()
    {
        Scaler =  Random.Range(0,1);
    }

    void Update()
    {
        transform.localScale += new Vector3(Scaler,Scaler,Scaler);
    }
}
