using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hutero : MonoBehaviour{

    public event Action< Collision > onCollisionEnter;

    private void OnCollisionEnter( Collision collision ){
        if( onCollisionEnter != null ){
            onCollisionEnter( collision );
        }
    }

    private void OnCollisionStay( Collision collision ){
    }
}