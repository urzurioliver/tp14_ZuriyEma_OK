using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float timer = 60;
    public UIMANAGER uiManagerScript;
    public GameObject panelLose;

    // Start is called before the first frame update
    void Start()
    {
        panelLose.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0){
            timer = 0;
            uiManagerScript.UpdateTimer(timer);
            panelLose.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else {
            uiManagerScript.UpdateTimer(timer);
        }
       
    }

}
