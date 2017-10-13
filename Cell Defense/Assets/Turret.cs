using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Turret : MonoBehaviour {

    public int antibodies = 0;
    public GameObject antibody;
    public GameObject ab;
    public GameObject ab1, ab2, ab3;
    public float time;
    double[] AntiPositionsX = new double[3] { -1.9, -2, -1.8 };
    double[] AntiPositionsY = new double[3] { 0.2, -0.8, -0.5 };
    GameObject[] AB = new GameObject[] {};
    
    // Use this for initialization
    void Start () {
        antibodies = 1;
        time = 3;
        ab = antibody;
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

	    if (antibodies < 3 && time >= 3)
        {
            Debug.Log(time);
            Instantiate(ab);
            antibodies++;
            time = 0;

        }
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "virus" && ab1 != null)
        {
            ab1.GetComponent<Antibody>().destination = collision.transform.position;
        }
    }
}
