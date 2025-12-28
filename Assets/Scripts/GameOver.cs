using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update

    
    //Para poder usar os campos de texto e mostrar a (pontuação) e o (recorde) do jogo
    public Text pontuacao, recorde;

    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (PassaDados.zerarTudo)
        {

            //Para passar os valores para o campo de texto da (Cena)
            pontuacao.text = "0";

            recorde.text = "0";
        }
        else {

            //Para passar os valores para o campo de texto da (Cena)
            pontuacao.text = PassaDados.pontos.ToString();

            recorde.text = PassaDados.maximo.ToString();
        }        
    }
}
