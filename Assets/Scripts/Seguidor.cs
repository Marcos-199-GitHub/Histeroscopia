using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor : MonoBehaviour{
    public bool      follow = false;
    public Transform target;
    public Vector3   offset_pos = Vector3.zero;
    public Vector3   offset_rot = Vector3.zero;

    private void Update(){
        if( follow == false ){
            return;
        }

        transform.position = target.position + offset_pos;
        transform.rotation = target.rotation;
        transform.Rotate( offset_rot );
    }
}