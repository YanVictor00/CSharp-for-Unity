using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public class Arma
    {
        string nome;
        string tipo;
        public Arma(string ArmaNome, string ArmaTipo)
        {
            nome = ArmaNome;
            tipo = ArmaTipo;
        }
        public string getNome()
        {
            return nome;
        }
        public string setNome()
        {
            return nome = nome2;
        }
    }    

    int vida;
    float velocidade;

    Arma espada;

    void Start()
    {
        espada = new Arma("Agulha", "Espada");
        Debug.Log(espada.getNome());

        espada.setNome("Sangrenta");
        Debug.Log(espada.setNome());
    }
}