using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest2 : MonoBehaviour
{
    public bool EndDialog;
    public GameObject Dialog1;
    public GameObject Dialog2;
    public Picked_Quest Picked_Quest;
    public bool End_Dialog;
    public InventoryAlter InventoryAlter;
    public NextClick2 NextClick2;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (EndDialog == true)
        {
            Time.timeScale = 1;
            Picked_Quest.Quest2 = true;
            Dialog1.SetActive(false);
        }
        if (End_Dialog == true)
        {
            Time.timeScale = 1;
            Picked_Quest.Quest2 = false;
            Dialog1.SetActive(false);
        }

    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            Debug.Log(Picked_Quest.end_Quest2);
            if (Picked_Quest.end_Quest2 == false)
            {
                Dialog1.SetActive(true);

            }
            if (Picked_Quest.TextDone2 == true)

            {
                Dialog1.SetActive(false);
                if (InventoryAlter.strongestPotion > 0)
                {



                    Picked_Quest.end_Quest2 = true;

                    Dialog2.SetActive(true);
                    InventoryAlter.strongestPotion -= 1;

                    // if (Dialog_NextClick.questSpenser_Script.End_Dialog == true)
                    // {
                    //     Dialog2.SetActive(false);
                    // }
                }
            }

        }
    }
}
