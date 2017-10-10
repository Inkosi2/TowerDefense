using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using System;

public class PathSkip : MonoBehaviour
{

    public int indexNode2;
    public GameObject bridge;

    Random rnd = new Random();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<SpriteRenderer>().color = Color.red;

        if (other.gameObject.tag == "virus")
        {
            if (bridge.GetComponent<Bridge>().isEmpty) //el puente está vacío
            {
                if (Random.Range(0, 1) == 0)
                {
                    other.gameObject.GetComponent<Virus>().i = indexNode2;
                }
            }
        }
    }
}
