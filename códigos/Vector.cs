using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector2 pos;
    public Vector3 pos3;

    void Start()
    {
        pos3 = new Vector3(3f,3f,3f); //or pos2.x = 5f;
        transform.position = pos3;
    }


    void Update()
    {
        
    }
}