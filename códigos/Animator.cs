using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rig;
    private Animator anime;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            anime.SetBool("IsAtk", true);
        }
        else
        {
            anime.SetBool("IsAtk", false);
        }

        if(Input.GetKey(KeyCode.D))
        {
            rig.velocity = new Vector2.right * speed;
            anime.SetBool("IsRun", true);
            transform.eulerAngles = new Vector2(0, 0);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            rig.velocity = new Vector2.left * speed;
            anime.SetBool("IsRun", true);
            transform.eulerAngles = new Vector2(0, 180f);
        }
        else
        {
            anime.SetBool("IsRun", false);
        }
    }
}