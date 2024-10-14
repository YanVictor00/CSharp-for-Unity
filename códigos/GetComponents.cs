using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rig;
    public BoxCollider box;
    public Player player;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();
        player = GetComponent<Player>();
    }
    void Update()
    {
        
    }
}