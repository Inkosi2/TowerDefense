using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using System;

public class PathSkip : MonoBehaviour
{

    public int indexNode2;
    public GameObject bridge;

    Random rnd = new Random();

    public float rand;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rand = Random.Range(0.0f, 1.0f);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "virus")
        {
            if (bridge.GetComponent<Bridge>().isEmpty) //el puente está vacío
            {
                if (rand >= 0.5f)
                {
                    other.gameObject.GetComponent<Virus>().i = indexNode2;
                }
            }
        }
    }
}
