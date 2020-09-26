using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject manzana;
    public float tiempo = 2f, rango = 10f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creador", 0.0f, tiempo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Creador()
    {
        Vector3 SpawnPosition = new Vector3(0,0,0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * rango;
        SpawnPosition = new Vector3(SpawnPosition.x, SpawnPosition.y, 0);

        GameObject apple = Instantiate(manzana, SpawnPosition, Quaternion.identity);
    }
}
