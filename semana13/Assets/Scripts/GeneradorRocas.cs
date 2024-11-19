using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorRocas : MonoBehaviour
{
    public GameObject prefabRoca;
    private float randomX;
    private float randomY;
    private int rocasEnJuego;

    void Start()
    {
        rocasEnJuego = 0;
        StartCoroutine(oleadaRocas());
    }

    void Update()
    {
        
    }

    public void CrearRoca()
    {
            randomX = Random.Range(9f, 9.25f);
            randomY = Random.Range(-4f, 3f);
            GameObject a = Instantiate(prefabRoca) as GameObject;
            a.transform.position = new Vector3(randomX, randomY, 0f);
            a.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-300f,0f));
            rocasEnJuego++;
    }

    IEnumerator oleadaRocas()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);

            if (rocasEnJuego < 6)
            {
                CrearRoca();
            }
        }
    }
}