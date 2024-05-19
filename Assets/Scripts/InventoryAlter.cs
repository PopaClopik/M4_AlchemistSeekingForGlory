using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAlter : MonoBehaviour
{
    public int gipnoGrib;
    public int muhomorApetitGrib;
    public int pogankaObikGrib;
    public int fireGrib;
    public int strongestGrib;

    public int polan;
    public int boyaresnic;
    public int borhevic;

    public int strongestPotion;
    public int hillPotion;
    public int unvisibalPotion;
    public int unbornPotion;
    public int slipPotion;
    public static InventoryAlter instance;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ItemCount() 
    {

    }

}
