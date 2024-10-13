using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
        public string inimigo01 = "Orc";
        public string inimigo02 = "Elfo";
        public string inimigo03 = "Anão";

        public string[] meusinimigos = new string[] {"Zumbi","Crepper","Slenderman"}
    void Start()
    {
        Debug.Log(meusinimigos[2]);
    }


    void Update()
    {
        
    }
}