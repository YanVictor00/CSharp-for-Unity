using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigbody rig;
    float speed = 3f;

    void Start()
    {
        rig = GetComponent<Rigbody>();
    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rig.velocity = new Vector3(1f,0,0) * speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            rig.velocity = new Vector3(-1f,0,0) * speed;
        }
        if(Input.GetKey(KeyCode.W))
        {
            rig.velocity = new Vector3(0,0,1) * speed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            rig.velocity = new Vector3(0,0,-1) * speed;
        }
        //if (Input.GetKeyDown(KeyCode."QUALQUER TECLA"))
        //if (Input.GetKeyUp(KeyCode."QUALQUER TECLA"))
    }
}