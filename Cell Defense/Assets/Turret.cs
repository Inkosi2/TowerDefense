using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Turret : MonoBehaviour {

    public int antibodies = 0;
    public GameObject antibody;
    public GameObject ab1, ab2;
    public bool isDead;
    public float time;
    double[] AntiPositionsX = new double[3] { -1.9, -2, -1.8 };
    double[] AntiPositionsY = new double[3] { 0.2, -0.8, -0.5 };
    GameObject[] AB = new GameObject[] {};
    
    

    // Use this for initialization
    void Start () {
        ab2 = antibody;
        ab1 = (GameObject)Instantiate(ab2, new Vector3(-1.8f, -0.5f, 0.75f), Quaternion.Euler(0, 0, 0));
        antibodies = 1;
        time = 3;
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

	    if (isDead && time <= 3)
        {
            ab1 = (GameObject)Instantiate(antibody, new Vector3(-1.8f, -0.5f, 0.75f), Quaternion.Euler(0, 0, 0));
            time = 0;
            isDead = false;
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
