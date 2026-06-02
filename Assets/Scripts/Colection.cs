using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colection : MonoBehaviour
{
    private int score = 0;
    UIMANAGER uiManagerScript;
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
}
}
