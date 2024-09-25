using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasCasos : MonoBehaviour{
    public Cortina cortina;
    public GameObject errorMessage;
    public GameObject molestandoMessage;
    public TextMeshProUGUI textResultado;
    public float tiempoSimulado = 0;
    public int conteoMolestias = 0;
    public float tiempoMolestias = 0;

    private bool loaded = false;

    private void Start(){
        cortina.gameObject.SetActive(true);
    }

    private void Update(){
        textResultado.text = "Tiempo Simulado: " + tiempoSimulado / 60 + " minutos \n\n" +
                             "Conteo Molestias: " + conteoMolestias + "\n\n" +
                             "Tiempo Molestias: " + tiempoMolestias + " segundos";
        if (cortina.abierta || cortina.ready == false || loaded){
            return;
        }

        SceneManager.LoadScene(0);
        loaded = true;
    }

    public void irAMenu(){
        cortina.cerrarCortina();
    }

    public void showError(){
        errorMessage.SetActive(true);
    }

    public void hideError(){
        errorMessage.SetActive(false);
    }

    public void showMolestando(){
        molestandoMessage.SetActive(true);
    }

    public void hideMolestando(){
        molestandoMessage.SetActive(false);
    }
}