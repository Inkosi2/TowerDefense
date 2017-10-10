using UnityEngine;
using System.Collections;

public class Path1 : MonoBehaviour {

    public GameObject n1, n2;
    public Queue obj = new Queue();


    // Use this for initialization
    void Start ()
    {
        obj.Enqueue(n1);
        obj.Enqueue(n2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
