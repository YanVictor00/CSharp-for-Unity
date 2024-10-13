using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public static int contadorInimigos;

    public Inimigos()
    {
        contadorInimigos++;
    }
    public static int Adicionar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int vida;

    public static Inimigos meuInimigo;

    private void Start()
    {
        meuInimigo = this;
    }
}