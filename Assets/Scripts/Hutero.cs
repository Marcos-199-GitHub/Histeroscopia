using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hutero : MonoBehaviour{

    public GameManager gameManager;

    private void OnCollisionEnter( Collision collision ){
        gameManager.onCollisionEnterUtero( collision );
    }

    private void OnCollisionExit( Collision collision ){
        gameManager.onCollisionExitUtero( collision );
    }

}