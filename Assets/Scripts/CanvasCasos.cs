using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasCasos : MonoBehaviour{
    public Cortina cortina;
    public GameObject errorMessage;
    public GameObject molestandoMessage;
    
    

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
    
    
    public void showError(){
        errorMessage.SetActive( true );
    }
    
    public void hideError(){
        errorMessage.SetActive( false );
    }
    
    public void showMolestando(){
        molestandoMessage.SetActive( true );
    }
    
    public void hideMolestando(){
        molestandoMessage.SetActive( false );
    }

}