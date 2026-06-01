using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colection : MonoBehaviour
{
    private int objetosRecolectados = 0;
    public UIMANAGER uiManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        uiManagerScript.UpdateScore(objetosRecolectados);
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Coleccionable"))
        {
        Destroy(col.gameObject);
        Debug.Log("objeto recolectado");
        objetosRecolectados++;
        }
}
}
