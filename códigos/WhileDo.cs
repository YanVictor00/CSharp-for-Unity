using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int vida = 5;

    void Start()
    {
        //While(vida < 10)
        // {
        //      vida++;
        //      Debug.Log(vida);
        //}    or

        do
        {
            Debug.Log(vida);
            vida++;
        } while (vida < 10);
    }

    void Update()
    {
        
    }
}