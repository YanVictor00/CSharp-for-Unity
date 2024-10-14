using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //<<<----------

public class CanvasController : MonoBehaviour
{
    public Text myText

    void Start()
    {
    }
    void Update()
    {
        if(Input.GetKey(KeyCodeDown.Space))
        {

        }
    }
    public void ChangeText()
    {
        myText.text = "Apereci";
    }
}