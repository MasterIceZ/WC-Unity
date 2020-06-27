using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class FindItem : MonoBehaviour
{
    static public List<GameObject> target;
    private float dist;
    private GameObject Obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Mathf.Infinity;
        foreach(GameObject x in target){
            if(Vector3.Distance(gameObject.transform.position,x.transform.position)<dist){
                dist = Mathf.Min (Vector3.Distance(gameObject.transform.position,x.transform.position),dist);
                Obj = x;
            }
        }
        gameObject.GetComponent<AICharacterControl>().target = Obj.transform;    
    }
    
}
