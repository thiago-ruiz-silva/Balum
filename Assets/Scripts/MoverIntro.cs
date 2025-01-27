        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverIntro : MonoBehaviour
{
    // Start is called before the first frame update

    //Para passar os objetos que serão usado na (Cena)
    public GameObject canvas, balum, recorde; 

    //Para determinar a velocidade que o (Balão) sobe
    public int velocidade;

    //Para poder usar a (Animação)
    Animator animacao;

    void Start()
    {

        //Para (Startar) a animação
        animacao = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        //Para mover o (Balão)
        transform.Translate(0, velocidade * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
     
        //Para colisão
        if (collision.gameObject.CompareTag("Final"))
        {

            //Para iniciar a contagem de tempo que fará a letra ("u") aparecer na tela inicial do jogo
            StartCoroutine(MostrarImagemBalum());

            //Para chamar a animação
            animacao.Play("Explodir");

            //Para destruir o (Balão)
            Destroy(this.gameObject, 0.3f);

            
            //Para que esses objetos somente sejão visível depois que o balão explodir
            canvas.SetActive(true);

            recorde.SetActive(true);            
        }
    }

    //Para a contagem de tempo que fará a letra ("u") aparecer
    IEnumerator MostrarImagemBalum()
    {

        //Para esperar (X) segundos
        yield return new WaitForSeconds(0.2f);

        //Para a imagem aparecer na tela do jogo
        balum.SetActive(true);
    }
}
