using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string[] nomesNPC = new string[3];
    public List<string> nomeInimigos = new List<string>();

    void Start()
    {
        nomesNPC[0] = "Alan";
        nomesNPC[1] = "Fall";
        nomesNPC[2] = "Cap";

        nomeInimigos.Add("NexTage");
        nomeInimigos.Add("Falso");
        nomeInimigos.Add("Capucino");

        foreach (string elemento in nomeInimigos)
        {
            Debug.Log(elemento);
        }
        //  or
        //for (int i - 0; i < nomesNPC.Length; if++)
        //{
        //    Debug.Log(elemento);
        //}
    }


    void Update()
    {
        
    }
}