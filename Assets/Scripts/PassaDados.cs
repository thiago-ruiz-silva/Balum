using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassaDados : MonoBehaviour
{
    //Esse script é para poder passar dados de um script para outro
    //Esse script deve ser colocar no (Main Camera) para que funcione corretamente


    //Essa variável serve para aumentar a velocidade de movimento dos (Spikes)
    //É um "Tipo" de variável "Global"
    public static float velocidadeSpikeCima, velocidadeSpikeMeio, velocidadeSpikeBaixo;
    //(SpikeMeio) || (SpikeCima) || (SpikeBaixo) ||



    //Essas variáveis vão mudar depois que o (Spike) colidir com o final da tela
    //Isso serve para que só seja criado um novo (Spike) depois que o (Spike) saia da tela do jogo
    public static bool isBateuSpikeCima, isBateuSpikeMeio, isBateuSpikeBaixo;
    //(SpikeMeio) || (SpikeCima) || (SpikeBaixo) || (CriarObjetos)



    //Essa variável é para que os espinhos parem ao chegar no final da tela do jogo
    //E também serve para que os espinhos só se movam se essa variável for (false)
    public static bool pararEspinhos;
    //(MoverEspinhos)



    //Essa variável é para que o jogo só comece depois que os espinhos cheguem ao fim da tela do jogo
    public static bool comecarJogo;
    //(MoverEspinhos) || (CriarObjetos)



    //Variável (pontos) para contar os pontos feitos no jogo  || Variável (maximo) para armazenar o recorde
    public static int pontos, maximo;
    //(SpikeMeio) || (SpikeCima) || (SpikeBaixo) ||



    //Para determinar o tempo que vai demorar para que o a outra (Cena) seja chamada
    public static float tempoMudarCena;

    //Para determinar que o jogo (Acabou)
    public static bool isFinal;
    //(Player)



    //Para passar o valor do (recorde) para a tela inicial ***ISSO É UMA GAMBIARRA***
    //Essa *GAMBIARRA* é necessário porque não consegui fazer o valor do (recorde) ser passado para a tela inicial
    //Pelo script (GameOver) || Lembrar de nos próximos jogos melhorar essa parte
    public Text recorde, pontosJogar;

    public static bool zerarTudo;

    void Start()
    {

        //Para (Startar) a velocidade dos (spikes)
        velocidadeSpikeCima = 3;
        velocidadeSpikeMeio = 3;
        velocidadeSpikeBaixo = 3;

        //Para (Startar) as variáveis bool
        isBateuSpikeCima = false;
        isBateuSpikeMeio = false;
        isBateuSpikeBaixo = false;

        pararEspinhos = false;

        comecarJogo = false;

        pontos = 0;

        //Para quando começar o jogo o valor do (recorde) seja passado para a variável (maximo)
        maximo = PlayerPrefs.GetInt("recorde", maximo);

        isFinal = false;

        //GAMBIARRA para passar o valor do (recorde) para a tela inicial
        recorde.text = maximo.ToString();

        //Para poder passar os pontos para a (Cena) (Jogar) || Para que os pontos apareçam na tela durante o jogo
        pontosJogar.text = pontos.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        //Para que os pontos sejam atualizados durante o (Jogo) e apareçam na tela do (Jogo)
        pontosJogar.text = pontos.ToString();
        

        //Para que depois do (Balão) ser destruído, o tempo para mudar de (Cena) comece a ser contado 
        if (isFinal)
        {
            //Para contar o tempo
            tempoMudarCena += Time.deltaTime;

        }

        //Para que se o tempo for maior que 1, a (cena) seja chamada
        if (tempoMudarCena > 1)
        {
            //Para chamar a (Cena) (Recorde)
            if (pontos > maximo)
            {

                //Analizar essa parte em (Projetos) (Futuros)
                maximo = pontos;

                PlayerPrefs.SetInt("recorde", maximo);

                UnityEngine.SceneManagement.SceneManager.LoadScene("Recorde");
            }

            else
            {
                //Para chamar a (Cena) (GameOver)
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");

            }

            //Para que depois de chamar uma das (Cenas) e clicar no (Botão) (Jogar) não de o (bug)  ||  Para saber qual é o (bug), tire essa parte do código
            tempoMudarCena = 0;
        }
        
    }
}
