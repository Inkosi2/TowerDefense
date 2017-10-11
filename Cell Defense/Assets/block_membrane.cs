using UnityEngine;
using System.Collections;

public class block_membrane : MonoBehaviour {
    public bool built;
	// Use this for initialization
	void Start () {
        built = false;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<SpriteRenderer>().enabled = built;
        GetComponent<BoxCollider2D>().enabled = built;
    }
}
