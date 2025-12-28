using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botoes : MonoBehaviour
{

    //Para poder mostrar e não mostrar as mensagens ---Na (Cena) (Mensagem)---
    public GameObject mensagemDoacao, mensagemPix, mensagemPayPal;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Método para fechar o app
    public void Zerar ()
    {

        PlayerPrefs.SetInt("recorde", 0);

        PassaDados.zerarTudo = true;
    }

    //Método que chama a cena *CenaJogar*
    public void Jogar ()
    {

        //Para voltar para a (Cena) (Jogar)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogar");
    }


    //Para (Chamar) a (Cena) (Mensagem) que é a (Cena) para (Doação) do (Jogo)
    public void Doar()
    {

        //Para (Chamar) a (Cena) (Mensagem)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Mensagem");
    }

    //Para (Voltar) para a (Cena) (Inicial) do (Jogo)
    public void Inicio()
    {

        //Para (Chamar) a (Cena) (Inicio)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Inicio");
    }

    //Para copiar a (Chave) (Pix) de doação do (Jogo)
    public void CopiarChavePix()
    {

        //Para copiar a (Chave) (Pix)
        GUIUtility.systemCopyBuffer = "thiagoruiz.y2@gmail.com";


        //Para que a mensagem (Doação) desapareça depois que o (Botão) (Copiar Chave Pix) for pressionado
        mensagemDoacao.SetActive(false);
        //Para mostrar a (Mensagem) (Chave Pix copiada com sucesso) depois que o (Botão) (Copiar Chave Pix) for pressionado
        mensagemPix.SetActive(true);

        //Para que não apareça a mensagem do (PayPal)
        mensagemPayPal.SetActive(false);
    }

    //Para copiar o (Email) de doação do (PayPal)
    public void CopiarEmail()
    {
        //Para copiar a (Chave) (Pix)
        GUIUtility.systemCopyBuffer = "thiagoruiz.y2@gmail.com";


        //Para que a mensagem (Doação) desapareça depois que o (Botão) (PayPal Donation) for pressionado
        mensagemDoacao.SetActive(false);
        //Para mostrar a (Mensagem) (Email copiado com sucesso) depois que o (Botão) (Copiar Chave Pix) for pressionado
        mensagemPayPal.SetActive(true);

        //Para que não apareça a mensagem do (Pix)
        mensagemPix.SetActive(false);

    }
}
