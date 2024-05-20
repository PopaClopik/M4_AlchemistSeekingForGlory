using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemUp : MonoBehaviour
{
    public InventoryAlter InventoryAlter;
    private int IdItem;

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
                IdItem = 0;
                InventoryAlter.gipnoGrib += 1;
                Destroy(gameObject);
            }
        }
        else if (muhomorApetitGrib == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                IdItem = 1;
                InventoryAlter.muhomorApetitGrib += 1;
                Destroy(gameObject);
            }
        }
        else if (pogankaObikGrib == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                IdItem = 2;
                InventoryAlter.pogankaObikGrib += 1;
                Destroy(gameObject);
            }
        }
        else if (fireGrib == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                IdItem = 3;
                InventoryAlter.fireGrib += 1;
                Destroy(gameObject);
            }
        }
        else if (strongestGrib == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                IdItem = 4;
                InventoryAlter.strongestGrib += 1;
                Destroy(gameObject);
            }
        }
        else if (polan == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                IdItem = 5;
                InventoryAlter.polan += 1;
                Destroy(gameObject);
            }
        }
        else if (boyaresnic == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                IdItem = 6;
                InventoryAlter.boyaresnic += 1;
                Destroy(gameObject);
            }
        }
        else if (borhevic == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                IdItem = 7;
                InventoryAlter.borhevic += 1;
                Destroy(gameObject);
            }
        }
    }
}
