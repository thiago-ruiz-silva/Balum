using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update[

    //Para poder usar o (Rigidbody)
    private Rigidbody2D body;
    //Força do movimento (Para cima) || Pode ser alterada no (Unity)
    public float forca = 2.0f;

    //Para poder usar a (Animação)
    Animator animacao;

    void Start()
    {

        //Para (Startar) o (Rigidbody) || E a animação de explosão
        body = GetComponent<Rigidbody2D>();
        animacao = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     
        //Para que quando houver um toque na tela (Aconteça (Algo)) ---Nesse caso o (Balão) vai subir um pouco---
        if (Input.GetMouseButtonDown(0))
        {

            //Para mover o (Player) para cima (Depois de mover, a (gravity) do (Rigidbody) "puxa" o (Player) pra baixo)) 
            body.linearVelocity = Vector2.up * forca;
        }
    }

    //Método pra colisão
    public void OnCollisionEnter2D(Collision2D colisao)
    {
        
        //Para quando o (Player) colidir com o (Espinho)
        if (colisao.gameObject.CompareTag("Espinho")) {

            //Para (Rodar) a animação do balão explodindo
            animacao.Play("Explodir");

            //Para destruir o (Balão)
            Destroy(this.gameObject, 0.33f);

            //Para poder mudar de (Cena)
            PassaDados.isFinal = true;
        }

        //Para quando o (Player) colidir com o (Spike)
        if (colisao.gameObject.CompareTag("Spike"))
        {

            //Para (Rodar) a animação do balão explodindo
            animacao.Play("Explodir");

            //Para destruir o (Balão)
            Destroy(this.gameObject, 0.3f);

            //Para poder mudar de (Cena)
            PassaDados.isFinal = true;
        }        
    }
}
