using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasCasos : MonoBehaviour{
    public Cortina cortina;

    private bool loaded = false;

    private void Start(){
        cortina.gameObject.SetActive( true );
    }

    private void Update(){
        if( cortina.abierta || cortina.ready == false || loaded ){
            return;
        }

        SceneManager.LoadScene( 0 );
        loaded = true;
    }

    public void irAMenu(){
        cortina.cerrarCortina();
    }

}