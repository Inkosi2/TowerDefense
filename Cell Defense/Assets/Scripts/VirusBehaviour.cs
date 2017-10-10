using UnityEngine;
using System.Collections;

public class VirusBehaviour : MonoBehaviour {

	public GameObject destination;
    public GameObject path;

	Vector2 destinationV;
	bool movable;


    // Use this for initialization
    void Start () {
        movable = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (movable)
        {
            destinationV = destination.transform.position;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-(transform.position.x - destinationV.x), -(transform.position.y - destinationV.y));
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

      
    }

    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        if (collidedObject.gameObject.tag == "intersectionNode")
        {
            path = collidedObject.gameObject.GetComponent<NodeBehaviour>().chosenPath;
            Queue copy = new Queue(path.gameObject.GetComponent<Path1>().obj);
            transform.position = collidedObject.transform.position;
            destination = (GameObject)path.gameObject.GetComponent<Path1>().obj.Peek();
        }

        if (collidedObject.gameObject.tag == "movementNode")
        {

            transform.position = collidedObject.transform.position;
            collidedObject.gameObject.GetComponent<NodeBehaviour>().chosenPath.GetComponent<Path1>().obj.Dequeue();
            
            if (collidedObject.gameObject.GetComponent<Path1>().obj.Count <= 1)
            {
                movable = false;
            }
        }


    }

   
}
