using UnityEngine;
using System.Collections;
using System;

public class Antibody : MonoBehaviour {

    public double distX, distY, moduloDist, uniX, uniY;

    public Vector2 destination;

    public GameObject turret;

	// Use this for initialization
	void Start () {
        destination = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        distX = transform.position.x - destination.x;
        distY = transform.position.y - destination.y;

        moduloDist = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));

        uniX = -distX / moduloDist;
        uniY = -distY / moduloDist;

        if (uniX >= 0 && uniY >= 0)
            GetComponent<Rigidbody2D>().velocity = new Vector2((float)1.5 * (float)uniX, (float)1.5 * (float)uniY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "virus")
        {
            collision.gameObject.GetComponent<Virus>().hp--;
            turret.GetComponent<Turret>().isDead = true;
            turret.GetComponent<Turret>().time = 0;
            Destroy(turret.GetComponent<Turret>().antibody);
        }
    }
}
