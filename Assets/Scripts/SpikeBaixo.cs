using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBaixo : MonoBehaviour
{
    //Ver script (SpikeCima)
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(-PassaDados.velocidadeSpikeBaixo * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Final"))
        {

            Destroy(this.gameObject);

            PassaDados.isBateuSpikeBaixo = true;

            PassaDados.velocidadeSpikeBaixo++;

            PassaDados.pontos++;
        }

        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(this.gameObject);
        }
    }
}
