using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerehodForest : MonoBehaviour
{
    public GameObject pointTP;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<CharacterController>().enabled = false;
            other.gameObject.transform.position = pointTP.transform.position;
            Debug.Log("+1");
            other.gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }
   
}
