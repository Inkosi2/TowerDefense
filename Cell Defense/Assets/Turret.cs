using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Turret : MonoBehaviour {

    public int antibodies = 0;
    public GameObject antibody;
    public GameObject ab1, ab2, ab3;

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (antibodies < 1)
        {
            ab1 = Instantiate(antibody);
            antibodies++;
        }
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "virus")
        {
            ab1.GetComponent<Antibody>().destination = collision.transform.position;
        }
    }
}
