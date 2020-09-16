using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenItem3 : MonoBehaviour
{
    public int sz;
    public List <GameObject> Breakable;
    //GameObject Breakable[];
    private bool on = true;
    private int idx;
    void Start()
    {
        sz = Breakable.Count;
    }
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
        
        int Select = Random.Range(0,sz);
        return Select;
    }
}
