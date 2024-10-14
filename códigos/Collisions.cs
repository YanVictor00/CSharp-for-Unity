using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Tocou!");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Parou de tocar!");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Está tocando!");
    }
}    