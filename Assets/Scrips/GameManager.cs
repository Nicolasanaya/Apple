using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            //Cargo la escena de Juego
            SceneManager.LoadScene("Juego");
        }

        //Si pulsa la tecla I vuelve al inicio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Cargo la escena de Inicio
            SceneManager.LoadScene("Inicio");
        }

    }
}
