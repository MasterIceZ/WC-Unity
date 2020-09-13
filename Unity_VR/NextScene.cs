using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    void OnColliderEnter (Collision collision)
    {
        if(collision.gameObject.tag == "ExitScene")
        {
            SceneManager.LoadScene("LeapMotion");
        }
    }
}
