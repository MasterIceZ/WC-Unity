using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenItem2 : MonoBehaviour
{
    public List <GameObject> Breakable;
    private bool on = true;
    private int idx;
    void Update()
    {
        if(on)
        {
            StartCoroutine(Waiting());
        }
    }
    IEnumerator Waiting()
    {
        idx = SelectingItem();
        Instantiate(Breakable[idx],transform.position,transform.rotation);
        on = false;
        yield return new WaitForSeconds(2);
        on = true;
    }
    public int SelectingItem()
    {
        int Select = Random.Range(0,2);
        if(Select == 1)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}
