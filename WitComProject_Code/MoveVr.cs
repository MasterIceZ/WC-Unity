using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class MoveVR : MonoBehaviour
{
    private Vector2 pad;
    private float Dir;
    private Vector3 moveDir;
    public SteamVR_Input_Sources Hand;
    public float speed;
    public GameObject Head;
    public CapsuleCollider Collider;
    public GameObject AxisH;
    public float Dz;

    void Update(){
        Collider.height = Head.transform.localPosition.y;
        Collider.center = new Vector3(Head.transform.localPosition.x,Head.transform.localPosition.y/2,Head.transform.localPosition.z);
        moveDir = Quaternion.AngleAxis(Angle(pad) + AxisH.transform.localRotation.eulerAngles.y,Vector3.up) * Vector3.forward;
        updateInput();
        if(GetComponent<Rigidbody>().velocity.magnitude<speed&&pad.magnitude>Dz>){
            GetComponent<Rigidbody>().AddForce(moveDir * 30);
        }
    }
    public static float Angle(Vector2 p_Vector2){
        if(p_Vector2.x < 0){
            return 360-(Mathf.Atan2(p_Vector2.x,p_Vector2.y)*-1*Mathf.Rad2Deg);
        }
        else{
            return Mathf.Atan2(p_Vector2.x,p_Vector2.y)*Mathf.Rad2Deg;
        }
    }
    private void updateInput(){
        pad = SteamVR_Actions._default.MovementAxis.GetAxis(Hand);
    }
}
