using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    static public List <GameObject> Items;
    private GameObject now;

    // Start is called before the first frame update
    void Start() 
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn(){
        while(true){
            yield return new WaitForSeconds(10);
            now = Instantiate(Items[Random.Range(0,4)],new Vector3(Random.Range(-56,53),2,Random.Range(-20,20)),Quaternion.identity);
            FindItem.target.Add(now);
        }
    }
}
