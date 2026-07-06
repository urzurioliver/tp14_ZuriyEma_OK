using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractiveArea : MonoBehaviour
{
    private int score = 0;
    UIMANAGER uiManagerScript;
    public AudioSource winSound;
    // Start is called before the first frame update
    void Awake()
    {
        uiManagerScript =  FindObjectOfType<UIMANAGER>();
    }

    // Update is called once per frame
    void Update()
    {
        uiManagerScript.UpdateScore(score);
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Coleccionable"))
        {
        Destroy(col.gameObject);
        Debug.Log("objeto recolectado");
        score++;
        }
        if (score == 5){
            uiManagerScript.MostrarPantallaWin();
            Time.timeScale = 0;
            winSound.Play();
        }
}
}
