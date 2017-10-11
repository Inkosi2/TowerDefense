using UnityEngine;
using System.Collections;

public class Bridge : MonoBehaviour {

    public bool isEmpty;   
    public GameObject membranes;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        isEmpty = !membranes.GetComponent<block_membrane>().built;

    }

    
}
