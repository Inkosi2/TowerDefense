using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Virus : MonoBehaviour {
    public double  distX, distY, moduloDist, uniX, uniY;
    public Vector2 destiny;
    public int i = 0;
    public GameObject pathDefiner;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        destiny = pathDefiner.GetComponent<PathDefiner>().pathway[i].transform.position;

        distX = transform.position.x - destiny.x;
        distY = transform.position.y - destiny.y;

        moduloDist = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));

        uniX = -distX / moduloDist;
        uniY = -distY / moduloDist;

        GetComponent<Rigidbody2D>().velocity = new Vector2((float)uniX, (float)uniY);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "movementNode")
        {
            i++;
        }
    }

}
