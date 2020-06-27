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
        target = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Mathf.Infinity;
        Obj = null;
        foreach(GameObject x in target){
            if(x!=null){
                if(Vector3.Distance(gameObject.transform.position,x.transform.position)<dist){
                dist = Mathf.Min (Vector3.Distance(gameObject.transform.position,x.transform.position),dist);
                Obj = x;
            }
            }
        }
        if(Obj!=null){
            gameObject.GetComponent<AICharacterControl>().target = Obj.transform;  
        }
          
    }
    
}
