using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{

    float timer = 60;
    public UIMANAGER uiManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0){
            timer = 0;
            uiManagerScript.UpdateTimer(timer);
            Time.timeScale = 0;
            uiManagerScript.MostrarPantallaGameOver();
            
        }
        else {
            uiManagerScript.UpdateTimer(timer);
        }
        if(Input.GetKeyDown(KeyCode.R )){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
            if(Input.GetKeyDown(KeyCode.Space)){
                Time.timeScale = 1;
            uiManagerScript.Intro();
    }
       
    }

}
