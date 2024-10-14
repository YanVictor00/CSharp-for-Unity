using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 3f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(new Vector3(-5f,0,0) * Time.deltaTime * speed);
        
        transform.Rotate(0,0,1f, Space.World);
    }
}