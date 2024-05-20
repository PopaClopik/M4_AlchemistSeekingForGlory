using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemUp : MonoBehaviour
{
    public InventoryAlter InventoryAlter;

    public bool gipnoGrib;
    public bool muhomorApetitGrib;
    public bool pogankaObikGrib;
    public bool fireGrib;
    public bool strongestGrib;

    public bool polan;
    public bool boyaresnic;
    public bool borhevic;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerStay(Collider other)
    {
        if ( gipnoGrib == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InventoryAlter.gipnoGrib += 1;
                Destroy(gameObject);
            }
        }
        else if (muhomorApetitGrib == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InventoryAlter.muhomorApetitGrib += 1;
                Destroy(gameObject);
            }
        }
        else if (pogankaObikGrib == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InventoryAlter.pogankaObikGrib += 1;
                Destroy(gameObject);
            }
        }
        else if (fireGrib == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InventoryAlter.fireGrib += 1;
                Destroy(gameObject);
            }
        }
        else if (strongestGrib == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InventoryAlter.strongestGrib += 1;
                Destroy(gameObject);
            }
        }
        else if (polan == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InventoryAlter.polan += 1;
                Destroy(gameObject);
            }
        }
        else if (boyaresnic == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InventoryAlter.boyaresnic += 1;
                Destroy(gameObject);
            }
        }
        else if (borhevic == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InventoryAlter.borhevic += 1;
                Destroy(gameObject);
            }
        }
    }
}
