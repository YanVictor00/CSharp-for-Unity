using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    piblic GameObject cubo;

    void Start()
    {
        GameObject copiaCubo = Instantiate(cubo, transform.position, transform.rotation);
        Destroy(copiaCubo.gameobject, 2f);
    }


    void Update()
    {
        
    }
}