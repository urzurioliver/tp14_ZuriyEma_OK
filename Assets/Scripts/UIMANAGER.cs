using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI txt_contador;
    public TextMeshProUGUI txt_time;

    
    // Start is called before the first frame update
    void Start()
    {
        
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
        txt_time.text = "Tiempo: " + currTime;
    }
}
