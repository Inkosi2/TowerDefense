using UnityEngine;
using System.Collections;

public class enemyManager : MonoBehaviour {

    // Use this for initialization
    int aux;
    public GameObject virus;
    int i;

    void Start() {
        aux = 0;
    }

    // Update is called once per frame
    void Update() {
        if (aux < 5 && Input.GetKey("q"))
        {
            Instantiate(virus, new Vector3(3.25f, -1.5f, 0.75f), Quaternion.Euler(0, 0, 0));
            aux++;
        }
    }
}

