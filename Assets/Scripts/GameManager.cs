using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public Hutero       hutero;
    public HapticPlugin hapticPlugin;
    public CanvasCasos  canvasCasos;
    public Seguidor     seguidor;

    public int         conteoMolestando = 0;
    public AudioSource audioMolestando;
    public AudioSource audioMolestando2;

    private void Start(){
        if( hapticPlugin.ModelType == "Not Connected" || hapticPlugin.SerialNumber == "Not Connected" ){
            hapticPlugin.UpdateDeviceInformation();
        }
    }

    private void Update(){
        if( hapticPlugin.ModelType == "Not Connected" || hapticPlugin.SerialNumber == "Not Connected" ){
            canvasCasos.showError();
        }
        else{
            canvasCasos.hideError();
            seguidor.follow = true;
        }
    }

    public void onCollisionEnterUtero( Collision obj ){
        canvasCasos.showMolestando();
        if( conteoMolestando % 5 == 0 && conteoMolestando > 0 && audioMolestando2.isPlaying == false ){
            audioMolestando2.Play();
        }
        else if( audioMolestando.isPlaying == false ){
            audioMolestando.Play();
        }

        conteoMolestando++;
    }

    public void onCollisionExitUtero( Collision obj ){
        canvasCasos.hideMolestando();
    }

    public void conectarHaptico(){
        hapticPlugin.UpdateDeviceInformation();
    }
}