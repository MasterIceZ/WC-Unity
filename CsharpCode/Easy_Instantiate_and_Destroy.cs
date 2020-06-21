using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  gameObject = Object that this script locate
  
  Instantiate = Build Obj
  
  Destroy = Destroy Obj;
  // T(O(n)) > Instatiate
  
  gameObject.SetActive(bool);
    set gameObject to bool status
    
  gameObject.activeSelf
    is Open/Close
*/
 
public class filename : MonoBehaviour
{
  public GameObject Name;
  void Start()
  {
    Instantiate(Name,Name.translate.position,Name.translate.rotation);
    
    Destroy(Name);
    
    gameObject.SetActive(false);
    
    Debug.Log(gameObject.activeSelf);
  }
  
  void Update()
  {
  
  }
}
