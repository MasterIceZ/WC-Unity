using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Input_Action : MonoBehaviour
{
    public SteamVR_Input_Sources Hand_type;
    public SteamVR_Action_Boolean Index_Finger;
    public SteamVR_Action_Boolean Middle_Finger;
    public GameObject Laser;
    void Update()
    {
        if(Index_Finger.GetLastStateDown(Hand_type)){
            print("XXXX" + Hand_type);
        }
        if(Index_Finger.GetLastState(Hand_type)){
            print("XXXX" + Hand_type);
            Laser.SetActive(true);
        }
        if(Index_Finger.GetLastStateUp(Hand_type)){
            print("XXXX" + Hand_type);
            Laser.SetActive(false);
        }
    }
}
