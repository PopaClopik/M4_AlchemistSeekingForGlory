using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picked_Quest : MonoBehaviour
{
    public bool Quest1;
    public GameObject Text1;
    public GameObject Text2;
    public bool end_Quest1;
    public bool TextDone;
    public bool TextDone2;
    public bool Quest2;
    public bool end_Quest2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (end_Quest1 == false)
        { 
        if (Quest1 == true)
        {
            Text1.SetActive(true);
            TextDone = true;
        }
        else
        {
            Text1.SetActive(false);
        }
        }
        else
        {
            Text1.SetActive(false);
        }

        ///////////////////////////////////
        if (end_Quest1 == true && end_Quest2 == false)
        {
            if (Quest2 == true)
            {
                Text2.SetActive(true);
                TextDone2 = true;
            }
            else
            {
                Text2.SetActive(false);
            }
            
        }
        else
        {
            Text2.SetActive(false);
        }
    }
}
