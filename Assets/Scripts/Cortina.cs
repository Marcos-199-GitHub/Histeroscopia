using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cortina : MonoBehaviour{
    public Image image;
    public bool abierta = true;
    public float velocidad = 1f;
    public bool ready = false;
    private float alfa = 0;

    public void cerrarCortina(){
        ready = false;
        abierta = false;
    }

    public void abrirCortina(){
        ready = false;
        abierta = true;
    }

    private void Start(){
        alfa = 1;
        image.color = new Color(0, 0, 0, alfa);
        abrirCortina();
    }

    private void Update(){
        if (abierta){
            alfa -= velocidad * Time.deltaTime;
        }
        else{
            alfa += velocidad * Time.deltaTime;
        }

        if (alfa >= 1){
            ready = true;
            alfa = 1;
        }
        else if (alfa <= 0){
            ready = false;
            alfa = 0;
        }
        else{
            ready = false;
        }

        image.color = new Color(0, 0, 0, alfa);
    }
}