using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEspinhos : MonoBehaviour
{
    // Start is called before the first frame update
    //Para determinar a velocidade dos (Espinhos)
    public int velocidade;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Para só mover os (Espinhos) até o final da tela do jogo
        if (PassaDados.pararEspinhos == false)
        {

            //Para mover os (Espinhos)
            transform.Translate(-velocidade * Time.deltaTime, 0, 0);
        }
    }

    //Para tratar da colisão dos (Espinhos) com o (Final) da (Tela) do (Jogo)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        //Para checar a colisão com o final da tela do jogo
        if (collision.gameObject.CompareTag("Final"))
        {

            //Para parar os (Espinhos)
            PassaDados.pararEspinhos = true;

            //Para que comece a ser criados os (Spikes)
            PassaDados.comecarJogo = true;
        }
    }
}
