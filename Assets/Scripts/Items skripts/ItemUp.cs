using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemUp : MonoBehaviour
{
    public InventoryAlter InventoryAlter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Дотронулся");
        if (Input.GetKeyDown(KeyCode.E))
        {
            InventoryAlter.fireGrib += 1;
            Debug.Log("+1 гриб");
            Destroy(gameObject);
        }
    }
   
    //private void 
    //{
    //  Debug.Log("Дотронулся");
    //if (Input.GetKeyDown(KeyCode.E))
    //{
    //  InventoryAlter.fireGrib += 1;
    //Debug.Log("+1 гриб");
    //}
    //}
}
