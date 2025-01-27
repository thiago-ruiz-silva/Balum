using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaObjetos : MonoBehaviour
{
    // Start is called before the first frame update[

    //Para passar os objetos (Spikes)
    public GameObject spikeCima, spikeMeio, spikeBaixo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Para começar a criação de objetos || (PassaDados.comecarJogo) para que só seja criado objetos depois que os (Espinhos) chegarem ao final da tela do jogo
        if (PassaDados.comecarJogo)
        {

            //Para criar os objetos
            Instantiate(spikeCima, new Vector2(10, 3), Quaternion.identity);

            Instantiate(spikeMeio, new Vector2(15, 0), Quaternion.identity);

            Instantiate(spikeBaixo, new Vector2(20, -3), Quaternion.identity);

            PassaDados.comecarJogo = false;
        }

        //Para criar os objetos depois do (Spike) sair da tela do jogo
        if (PassaDados.isBateuSpikeCima)
        {

            Instantiate(spikeCima, new Vector2(10, 3), Quaternion.identity);

            //Para que só saia um objeto de cada vez  || depois que o (Spike) sair da tela, essa variável será mudada para (true) nos (Scripts) dos (Spikes)
            PassaDados.isBateuSpikeCima = false;
        }

        if (PassaDados.isBateuSpikeMeio)
        {

            Instantiate(spikeMeio, new Vector2(10, 0), Quaternion.identity);

            PassaDados.isBateuSpikeMeio = false;
        }

        if (PassaDados.isBateuSpikeBaixo)
        {

            Instantiate(spikeBaixo, new Vector2(10, -3), Quaternion.identity);

            PassaDados.isBateuSpikeBaixo = false;
        }
    }
}
