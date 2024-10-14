using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {

    }
    void FixedUpdate()
    {
        //if(Input.GetMouseButton(0)){}
        //if(Input.GetMouseButtonUp(0)){}
        //if(Input.GetMouseButtonDown(0)){}
        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
        }
    }
    private void OnMouseDown(){ Debug.Log("Clicou!"); }
    private void OnMouseDrag(){ Debug.Log("Arrastou!"); }
    private void OnMouseUp(){ Debug.Log("Soltou o Click!"); }
    private void OnMouseExit(){ Debug.Log("Passou o Ponteiro em cima!"); }
}