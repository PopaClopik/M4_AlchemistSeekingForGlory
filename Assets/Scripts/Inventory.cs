using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    List<Item> item;

    public GameObject CellContainer;
    public KeyCode TakeButton;

    void Start()
    {
        item = new List<Item> ();

       CellContainer.SetActive (false);

        for (int i = 0; i < CellContainer.transform.childCount; i++) 
        {
            item.Add(gameObject.AddComponent<Item>());
        }
    }

    // Update is called once per frame
    void Update()
    {
       ToggleInventory();

        if (Input.GetKeyDown(TakeButton))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 2f))
            {
                if (hit.collider.GetComponent<Item>())
                {
                    for (int i = 0; i < item.Count; i++)
                    {
                        if (item[i].id == 0)
                        {
                            item[i] = hit.collider.GetComponent<Item>();
                            DisplayItems();
                            Destroy(hit.collider.GetComponent<Item>().gameObject);
                            break;
                        }
                    }
                }
            }

        }
    }

    void ToggleInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
            CellContainer.SetActive(!CellContainer.activeSelf);
    }

    void DisplayItems()
    {
        

        for (int i = 0; i < item.Count; i++)
        {
            Transform cell = CellContainer.transform.GetChild(i);
            Transform icon = cell.GetChild(0);
            Image img = icon.GetComponent<Image>();

            if (item[i].id != 0)
            {
                
                img.enabled = true;
                img.sprite = Resources.Load<Sprite>(item[i].pathIcon);
            }
            else
            {
                img.enabled = false;
                img.sprite = null;
            }
            
        }
    }    
}
