using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MovimientoCesta : MonoBehaviour
{
    [SerializeField]private float velocidad = 3f;
    public int contadorcesta = 0;
    //public int contadorVida = 0;

    public Text textoPuntos;
    //public Text textoVida;
    public Text Resultado;
    Rigidbody2D rb;

    public AudioSource movimiento;
    public GameObject son;

    public AudioSource sonman;
    public GameObject man;

    private void OnTriggerEnter2D(Collider2D cesta)
    {
        Destroy(cesta.gameObject);
        contadorcesta = contadorcesta + 1;
        textoPuntos.text = "Puntos: " + contadorcesta.ToString();
    }

    

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        contadorcesta = 0;
        textoPuntos.text = "Puntos: " + contadorcesta.ToString();
    }

    bool Ganador()
    {
        if (contadorcesta == 10)
        {
            Instantiate(sonman);
            Resultado.text = "Ganaste :D";
            Resultado.enabled = true;
            Time.timeScale = 0;
            return true;
        }     
        else
        {
            return false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(movimiento);
        textoPuntos.text = contadorcesta.ToString();
        //textoVida.text = contadorVida.ToString();

        Resultado.enabled = false;

        Time.timeScale = 1;

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Ganador();


        if(Input.GetKey(KeyCode.A))
        {
            //Instantiate(movimiento);
            transform.position+=Vector3.left*velocidad*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            //Instantiate(movimiento);
            transform.position+=Vector3.right*velocidad*Time.deltaTime;
        }

        
        
    }
}
