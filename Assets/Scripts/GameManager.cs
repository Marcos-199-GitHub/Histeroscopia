using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public Hutero       hutero;
    public HapticPlugin hapticPlugin;
    public CanvasCasos  canvasCasos;

    private void Start(){
        if( hapticPlugin.ModelType == "Not Connected" || hapticPlugin.SerialNumber == "Not Connected" ){
            hapticPlugin.UpdateDeviceInformation();
        }

        hutero.onCollisionEnter += onCollisionEnter;
    }

    private void onCollisionEnter( Collision obj ){
    }
}