using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string nome;
    int vida;
    int velocidade;
    private int forcaPulo;

    private void Start()
    {
        DefinirNome();
    }
    void Atacar()
    {
        Debug.Log("Olá, mundo!");
    }
    string DefinirNome()
    {
        return nome = "Player One";
    }
}