using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Colection : MonoBehaviour
{
     public TextMeshProUGUI txt_contador;
     private int objetosRecolectados = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt_contador.text = ("objetos recolectados: " + objetosRecolectados);
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
