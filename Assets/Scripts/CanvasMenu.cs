using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMenu : MonoBehaviour{
    public  Cortina cortina;
    private int     caso   = 0;
    private bool    loaded = false;

    private void Update(){
        if( cortina.abierta || cortina.ready == false || loaded ){
            return;
        }

        SceneManager.LoadScene( caso );
        loaded = true;
    }

    public void exit(){
        Application.Quit();
    }

    public void cargarCaso( int casoh ){
        caso = casoh;
        cortina.cerrarCortina();
    }
}