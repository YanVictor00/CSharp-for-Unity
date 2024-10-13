using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        /*Inimigos inimigos1 = new Inimigos();
        Inimigos inimigos2 = new Inimigos();
        Inimigos inimigos3 = new Inimigos();
        Deubug.Log(Inimigos.contadorInimigos);
        Degug.Log(Inimigos.Adicionar(2,2));
        Debug.Log(Inimigos.meuInimigo.vida); */
    
    public int score;
    public static GameController controller;
    void start()
    {
        controller = this;
    }
    }
}