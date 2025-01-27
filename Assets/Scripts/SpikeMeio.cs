using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMeio : MonoBehaviour
{
    //Ver script (SpikeCima)
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Para movimentar o (Spike) do (Meio)
        transform.Translate(-PassaDados.velocidadeSpikeMeio * Time.deltaTime, 0, 0);
    }
    
    //Para tratar as (Colisões) do (Spike)
    private void OnCollisionEnter2D(Collision2D collision)
    {

        //Para (Destruir) o (Spike) se ele colidir com o (Final) da (Tela) do (Jogo)
        if (collision.gameObject.CompareTag("Final"))
        {

            //Para (Destruir) o (Spike)
            Destroy(this.gameObject);

            //Para que só possa ser criado outro (Spike) depois da colisão
            PassaDados.isBateuSpikeMeio = true;

            //Para que o próximo (Spike) (Nesse caso o do meio) se movimente mais rápido que o anterior
            PassaDados.velocidadeSpikeMeio++;

            //Para (Marcar) mais um (Ponto) no (Jogo)
            PassaDados.pontos++;
        }

        //Para quando o (Spike) colidir com o (Player)
        if (collision.gameObject.CompareTag("Player"))
        {

            //Para (Destruir) o (Spike)
            Destroy(this.gameObject);
        }
    }
}
