using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piso : MonoBehaviour
{

    public int contadorVida = 3;
    public Text textoVida;
    public Text Resultado;
    Rigidbody2D rb;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D piso)
    {
        Destroy(piso.gameObject);
        contadorVida = contadorVida - 1;
        textoVida.text = "Vida: " + contadorVida.ToString();
    }

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        contadorVida = 3;
        textoVida.text = "Vida: " + contadorVida.ToString();
    }
    bool Perdedor()
    {
       if (contadorVida == 0)
        {
            Resultado.text = "Perdiste :(";
            Resultado.enabled = true;
            Time.timeScale = 0;
            return true;

        }
        else
        {
            return false;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Perdedor();
    }
}
