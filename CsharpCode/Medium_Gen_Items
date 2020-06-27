using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public List <GameObject> Items;

    // Start is called before the first frame update
    void Start() 
    {
        StartCoroutine(wait_spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator wait_spawn(){
        while(true){
            yield return new WaitForSeconds(10);
            Instantiate(Items[Random.Range(0,4)],new Vector3(Random.Range(-56,53),2,Random.Range(-20,20)),Quaternion.identity);
        }
    }
}
