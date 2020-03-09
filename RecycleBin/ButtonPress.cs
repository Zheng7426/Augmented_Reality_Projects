using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{

    //Add a declaration of gameobject array
    public Transform position;
    public GameObject[] newStuff; 
    public bool Variable = true;
    //public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
      
            if (other.transform.tag == "RightHand")
            {
            Debug.Log("enter right");
            //Add here the Y demotion by 0.03f
            transform.position = transform.position - new Vector3(0, 0.03f, 0);

            }

            if (other.transform.tag == "LeftHand")
            {

            //Add here the Y demotion by 0.03f
            transform.position = transform.position - new Vector3(0, 0.03f, 0);

        }

            
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "RightHand")
                {
            transform.position = transform.position + new Vector3(0, 0.03f, 0);
            //Add here the Y elevation by 0.03f

            if (Variable)
                     {
                    int newItemIndex = Random.Range(0, 4);
                    GameObject newItem = newStuff[newItemIndex];
                    Instantiate(newItem, new Vector3(0.422f, 1.1251f, 1.556f), Quaternion.identity); ;
                    Variable = false;
                     }
                }

                if (other.transform.tag == "LeftHand")
                {
                transform.position = transform.position + new Vector3(0, 0.03f, 0);
                //Add here the Y elevation by 0.03f

                if (Variable) {
                    int newItemIndex = Random.Range(0, 4);
                    GameObject newItem = newStuff[newItemIndex];
                    Instantiate(newItem, new Vector3(0.422f, 1.1251f, 1.556f), Quaternion.identity);

                    //Add here a Random generation of objects
                    Variable = false;

                    }
                }

    }


}

   

