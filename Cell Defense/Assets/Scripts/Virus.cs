﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Virus : MonoBehaviour {
    public double  distX, distY, moduloDist, uniX, uniY;
    public Vector2 destiny;
    public int i, hp;
    float auxSpeed, membraneTimer;
    public GameObject pathDefiner;

    // Use this for initialization
    void Start () {
        hp = 3;
        i = 0;
        auxSpeed = 1;
        membraneTimer = 0;
    }
	
	// Update is called once per frame
	void Update () {
        membraneTimer += Time.deltaTime;
        if (membraneTimer >= 1.5)
        {
            auxSpeed = 1;
        }
        if (i <= 26)
        {
            destiny = pathDefiner.GetComponent<PathDefiner>().pathway[i].transform.position;

            distX = transform.position.x - destiny.x;
            distY = transform.position.y - destiny.y;

            moduloDist = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));

            uniX = -distX / moduloDist;
            uniY = -distY / moduloDist;

            GetComponent<Rigidbody2D>().velocity = new Vector2((float)uniX * auxSpeed, (float)uniY) * auxSpeed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        if (hp == 0)
        {
            Destroy(gameObject);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "movementNode")
        {
            i++;
        }
        if (collision.gameObject.tag == "cell")
        {
            collision.gameObject.GetComponent<Cell>().hp--;
            Destroy(gameObject);
            collision.transform.localScale = new Vector3(collision.transform.localScale.x - 1, collision.transform.localScale.y - 1, collision.transform.localScale.z);
        }
        if (collision.tag == "membrane")
        {
            membraneTimer = 0;
            auxSpeed = 0.5F;
        }
    }

}
