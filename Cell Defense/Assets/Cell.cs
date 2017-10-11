using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {

    public int hp = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (hp == 0)
        {
            Destroy(gameObject);
            //Añadir algo para terminar el juego
        }
	}
}
