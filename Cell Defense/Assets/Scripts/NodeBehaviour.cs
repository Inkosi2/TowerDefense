using UnityEngine;
using System.Collections;

public class NodeBehaviour : MonoBehaviour {

	public int nodeAmount;
	public ArrayList nodos = new ArrayList();

    public GameObject path1;
    public GameObject path2;
    public GameObject path3;

    public GameObject chosenPath;

    // Use this for initialization
    void Start () {
        GameObject[] paths = new GameObject[3];
        for (int i = 0; i < 2; i++)
        {
            if(paths[i].GetComponent<PathContent>().duration > paths[i + 1].GetComponent<PathContent>().duration)
            {
                swap(paths[i], paths[i + 1]);
            }
        }
        

        chosenPath = paths[0];

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void swap(GameObject A, GameObject B)
    {
        GameObject c = A;
        A = B;
        B = c;
    }

    
}
