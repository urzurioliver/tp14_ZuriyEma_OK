using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI txt_contador;
    public TextMeshProUGUI txt_time;
    public GameObject panelWin;
    public GameObject panelLose;
    public GameObject panelIntro;
    public GameObject panelScore;
    public GameObject panelTimer;

    
    // Start is called before the first frame update
    void Start()
    {
        panelWin.gameObject.SetActive(false);
        panelLose.gameObject.SetActive(false);
        panelTimer.gameObject.SetActive(false);
        panelScore.gameObject.SetActive(false);
        panelIntro.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int objetosRecolectados)
    {
        txt_contador.text = "Objetos recolectados: " + objetosRecolectados;
    }
    public void UpdateTimer(float currTime)
    {
        txt_time.text = "Tiempo: " + Mathf.Ceil(currTime);
    }
    public void MostrarPantallaWin(){
        panelWin.gameObject.SetActive(true);
        panelTimer.gameObject.SetActive(false);
        panelScore.gameObject.SetActive(false);
    }
    public void MostrarPantallaGameOver(){
        panelLose.gameObject.SetActive(true);
        panelTimer.gameObject.SetActive(false);
        panelScore.gameObject.SetActive(false);
    }

 public void Intro(){
        panelIntro.gameObject.SetActive(false);
        panelTimer.gameObject.SetActive(true);
        panelScore.gameObject.SetActive(true);
    }
}

