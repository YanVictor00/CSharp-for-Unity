using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float vida;

    void Start()
    {
        if(vida <= 0)
        {
            Debug.Log("Game Over");
        }
        else
        {
            //Debug.Log("X");
        }
    }


    void Update()
    {
        
    }
}