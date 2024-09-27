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
    public TextMeshProUGUI contadorTexto;
    public float tiempoSimulado = 0;
    public int conteoMolestias = 0;
    public float tiempoMolestias = 0;

    private bool loaded = false;

    private void Start(){
        cortina.gameObject.SetActive(true);
    }

    private void Update(){
        int horas = (int)(tiempoSimulado / 3600);
        int minutos = (int)((tiempoSimulado % 3600) / 60);
        int segundos = (int)(tiempoSimulado % 60);

        int horasMolestias = (int)(tiempoMolestias / 3600);
        int minutosMolestias = (int)((tiempoMolestias % 3600) / 60);
        int segundosMolestias = (int)(tiempoMolestias % 60);

        textResultado.text = "Tiempo Simulado: " + horas.ToString("00") + ":" + minutos.ToString("00") + ":" + segundos.ToString("00") +
                             "\n\n" +
                             "Conteo Molestias: " + conteoMolestias + "\n\n" +
                             "Tiempo Molestias: " + horasMolestias.ToString("00") + ":" + minutosMolestias.ToString("00") + ":" +
                             segundosMolestias.ToString("00");

        contadorTexto.text = horas.ToString("00") + ":" + minutos.ToString("00") + ":" + segundos.ToString("00");
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