using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class filename : MonoBehaviour
{
  void Start()
  {
  
  }
  
  void Update()
  {
    if(/*condition*/){
      SceneManager.LoadScene("/*SceneName*/");
      Debug.Log(SceneManager.GetActiveScene().name);
      //Print out Now Scene on Console
    }
  }
}
