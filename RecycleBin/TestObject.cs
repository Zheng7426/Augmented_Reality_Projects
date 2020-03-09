using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject Button;
    public string OwnTag ;
    void Start()
    {
        
        Button  = GameObject.Find("button");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        string objectTag = other.transform.tag;

        if (objectTag == OwnTag) {

            //Implement the destruction
            Destroy(this);
			//Explain what this line do
            Button.GetComponentInChildren<ButtonPress>().Variable = true;
            // Using a VARIABLE parameter in the ButtonPress scirpt allows to check zhether or not the last istantiated object has been 
            //This updates the Variable in the ButtonPress script back to 'True'. So that pressing the button could now instantiate a new object again. 
        }
    }
}
