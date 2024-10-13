using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<string> tiposInimigos = new List<string>();   

    void Start()
    {
        tiposInimigos.Add("Ghost");
        tiposInimigos.Add("Elfo");
        tiposInimigos.Add("Thief");

        Debug.Log(tiposInimigos[0]);

       /* tiposInimigos.Insert(0, "Roxes");
        tiposInimigos.Clear();
        tiposInimigos.Toarray();
        if(tiposInimigos.Contains("Ghost")){Debug.Log("there's a ghost here")};
        */
    }


    void Update()
    {
        
    }
}