using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int forca;

    void Start()
    {
        switch (forca)
        {
            case 1:
                Debug.Log("Força nível 1")
            break;
            
            case 2:
                Debug.Log("Força nível 2")
            break;

            case 3:
                Debug.Log("Força nível Máxima")
            break;

            default:
                Debug.Log("Nenhum valor atribuído")
            break;
        }
    }

    void Update()
    {
        
    }
}