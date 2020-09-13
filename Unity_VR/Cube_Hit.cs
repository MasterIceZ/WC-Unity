using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Hit : MonoBehaviour
{
    public GameObject Effect_1,Effect_2;
    public AudioClip Sound_1,Sound_2;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Sphere")
        {
            //print("Sphere");
            Destroy(gameObject);
        }
        if(collision.gameObject.name == "Capsule")
        {
            //print("Capsule");
            Destroy(collision.gameObject);
            
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Sphere")
        {
            //Destroy(gameObject);
            Instantiate(Effect_1,transform.position,transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(Sound_1);
        }
        /*
        if(collision.gameObject.name == "Capsule")
        {
            //Destroy(collision.gameObject);
        } */
        else
        {
            Instantiate(Effect_2,transform.position,transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(Sound_2);
        }
    }
}
