using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest3 : MonoBehaviour
{
    public bool EndDialog;
    public GameObject Dialog1;
    public GameObject Dialog2;
    public Picked_Quest Picked_Quest;
    public bool End_Dialog;
    public InventoryAlter InventoryAlter;
    public NextClick3 NextClick3;

    void Update()
    {
        if (EndDialog == true)
        {
            Time.timeScale = 1;
            Picked_Quest.Quest3 = true;
            Dialog1.SetActive(false);
        }
        if (End_Dialog == true)
        {
            Time.timeScale = 1;
            Picked_Quest.Quest3 = false;
            Dialog1.SetActive(false);
        }

    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            Debug.Log(Picked_Quest.end_Quest3);
            if (Picked_Quest.end_Quest3  == false)
            {
                Dialog1.SetActive(true);

            }
            if (Picked_Quest.TextDone3 == true)

            {
                Dialog1.SetActive(false);
                if (InventoryAlter.spidPotion > 0)
                {



                    Picked_Quest.end_Quest3 = true;

                    Dialog2.SetActive(true);
                    InventoryAlter.spidPotion -= 1;

                   
                }
            }

        }
    }
}
