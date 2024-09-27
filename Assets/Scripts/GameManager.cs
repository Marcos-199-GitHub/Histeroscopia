using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public Hutero hutero;
    public HapticPlugin hapticPlugin;
    public CanvasCasos canvasCasos;
    public Seguidor seguidor;

    public int conteoMolestando = 0;
    public AudioSource audioMolestando;

    private bool isMolestando = false;

    private void Start(){
        
        if (hapticPlugin.ModelType == "Not Connected" || hapticPlugin.SerialNumber == "Not Connected"){
            hapticPlugin.UpdateDeviceInformation();
        }
    }

    private void Update(){
        if (hapticPlugin.ModelType == "Not Connected" || hapticPlugin.SerialNumber == "Not Connected"){
            canvasCasos.showError();
        }
        else{
            canvasCasos.hideError();
            seguidor.follow = true;
            canvasCasos.tiempoSimulado += Time.deltaTime;
            if (isMolestando){
                canvasCasos.tiempoMolestias += Time.deltaTime;
            }
        }
    }

    public void onCollisionEnterUtero(Collision obj){
        isMolestando = true;
        canvasCasos.showMolestando();
        audioMolestando.Play();
        canvasCasos.conteoMolestias++;
    }

    public void onCollisionExitUtero(Collision obj){
        isMolestando = false;
        canvasCasos.hideMolestando();
    }

    public void conectarHaptico(){
        hapticPlugin.UpdateDeviceInformation();
    }
}