using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class myButton : MonoBehaviour {

    public Button yourButton;
    public GameObject membrana;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
       
        
    }

    void TaskOnClick()
    {
        membrana.GetComponent<block_membrane>().built = !membrana.GetComponent<block_membrane>().built;
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    

}
