using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class enemyManager : MonoBehaviour {

    // Use this for initialization
    int aux;
    public GameObject virus;
    int i;
    float timer;
    public Stack<GameObject> enemies = new Stack<GameObject>();

    void Start() {
        aux = 0;
        timer = 0;
    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        if (aux < 5 && timer >= 2)
        {
            timer = 0;
            enemies.Push((GameObject)Instantiate(virus, new Vector3(3.25f, -1.5f, 0.75f), Quaternion.Euler(0, 0, 0)));
            enemies.Peek().GetComponent<Virus>().i = 0;
            aux++;
        }
    }
}

