using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class filename : MonoBehaviour
{
  public string name;
  public void isClick(){
    SceneManager.LoadScene(name);
  }
  /**
  To input from KB,Mouse
  KB :
  Input.GetKeyDown(Keycode.name)
  Mouse :
  Input.GetMouseButton(name)
  */
}
