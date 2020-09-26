using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manzana : MonoBehaviour
{
    public float velocidad = 5f;

  

    // Start is called before the first frame update
    void Start()
    {
        //textoPuntos.text = contadorcesta.ToString();
        //textoVida.text = contadorVida.ToString();

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.forward * velocidad * Time.deltaTime;
    } 

   
}
