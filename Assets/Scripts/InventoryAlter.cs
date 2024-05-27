﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryAlter : MonoBehaviour
{

    public int Coin;

    public int gipnoGrib;
    public int muhomorApetitGrib;
    public int pogankaObikGrib;
    public int fireGrib;
    public int strongestGrib;

    public int polan;
    public int boyaresnic;
    public int borhevic;

    public int strongestPotion;
    public TextMeshProUGUI silaPotionCount;
    public int hillPotion;
    public TextMeshProUGUI hillPotionCount;
    public int unbornPotion;
    public TextMeshProUGUI fireAspectPotionCount;
    public int hipnosisPotion;
    public TextMeshProUGUI hipnosisPotionCount;
    public int poisonPotion;
    public TextMeshProUGUI poisonPotionCount;
    public int spidPotion;
    public TextMeshProUGUI spidPotionCount;

    public static InventoryAlter instance;

    public Transform stoneSourceTransform;

    public GameObject Player;
    public GameObject gipnoGribObgect;
    public GameObject muhomorApetitGribObgect;
    public GameObject pogankaObikGribObject;
    public GameObject fireGribObject;
    public GameObject strongestGribObject;
    public GameObject polanObject;
    public GameObject boyaresnicObject;
    public GameObject borhevicObject;


    public bool Quest1Done;
    public bool Quest2Done;
    public bool Quest3Done;
    public bool Quest4Done;


    public bool end_Quest1;
    public bool end_Quest2;
    public bool end_Quest3;
    public bool end_Quest4;
    public bool Quest1;
    public bool Quest2;
    public bool Quest3;
    public bool Quest4;
    public bool TextDone;
    public bool TextDone2;
    public bool TextDone3;
    public bool TextDone4;

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

        DrawFirePotionUI();
        DrawHillPotionUI();
        DrawHipnosisPotionUI();
        DrawPoisonPotionUI();
        DrawSilaPotionUI();
        DrawSpidPotionUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gipnoGribMetod();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            muhomorApetitGribMetod();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            pogankaObikGribMetod();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            fireGribMetod();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            strongestGribMetod();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            polanMetod();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            boyaresnicMetod();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            borhevicMetod();
        }

    }

    private void gipnoGribMetod()
    {
        if (gipnoGrib > 0)
        {
            Debug.Log("Сработало");
            var spawnedStone = Instantiate(gipnoGribObgect);
            spawnedStone.transform.position = stoneSourceTransform.position;
            spawnedStone.GetComponent<Rigidbody>().AddForce(stoneSourceTransform.forward * 0);
            
            gipnoGrib -= 1; 
        }
    }
    private void muhomorApetitGribMetod()
    {
        if (muhomorApetitGrib>0)
        {
            Debug.Log("Сработало");
            var spawnedStone = Instantiate(muhomorApetitGribObgect);
            spawnedStone.transform.position = stoneSourceTransform.position;
            spawnedStone.GetComponent<Rigidbody>().AddForce(stoneSourceTransform.forward * 0);
            muhomorApetitGrib -= 1;
        }
    }
    private void pogankaObikGribMetod()
    {
        if (pogankaObikGrib > 0)
        {
            Debug.Log("Сработало");
            var spawnedStone = Instantiate(pogankaObikGribObject);
            spawnedStone.transform.position = stoneSourceTransform.position;
            spawnedStone.GetComponent<Rigidbody>().AddForce(stoneSourceTransform.forward * 0);
            pogankaObikGrib -= 1;
        }
    }
    private void fireGribMetod()
    {
        if (fireGrib > 0)
        {
            Debug.Log("Сработало");
            var spawnedStone = Instantiate(fireGribObject);
            spawnedStone.transform.position = stoneSourceTransform.position;
            spawnedStone.GetComponent<Rigidbody>().AddForce(stoneSourceTransform.forward * 0);
            fireGrib -= 1;
        }
    }
    private void strongestGribMetod()
    {
        if (strongestGrib > 0)
        {
            Debug.Log("Сработало");
            var spawnedStone = Instantiate(strongestGribObject);
            spawnedStone.transform.position = stoneSourceTransform.position;
            spawnedStone.GetComponent<Rigidbody>().AddForce(stoneSourceTransform.forward * 0);
            strongestGrib -= 1;
        }
    }
    private void polanMetod()
    {
        if (polan > 0)
        {
            Debug.Log("Сработало");
            var spawnedStone = Instantiate(polanObject);
            spawnedStone.transform.position = stoneSourceTransform.position;
            spawnedStone.GetComponent<Rigidbody>().AddForce(stoneSourceTransform.forward * 0);
            polan -= 1;
        }
    }
    private void boyaresnicMetod()
    {
        if (boyaresnic > 0)
        {
            Debug.Log("Сработало");
            var spawnedStone = Instantiate(boyaresnicObject);
            spawnedStone.transform.position = stoneSourceTransform.position;
            spawnedStone.GetComponent<Rigidbody>().AddForce(stoneSourceTransform.forward * 0);
            boyaresnic -= 1;
        }
    }
    private void borhevicMetod()
    {
        if (borhevic > 0)
        {
            Debug.Log("Сработало");
            var spawnedStone = Instantiate(borhevicObject);
            spawnedStone.transform.position = stoneSourceTransform.position;
            spawnedStone.GetComponent<Rigidbody>().AddForce(stoneSourceTransform.forward * 0);
            borhevic -= 1;
        }
    }

    public void DrawSilaPotionUI()
    {
        silaPotionCount.text = strongestPotion.ToString();
    }

    public void DrawSpidPotionUI()
    {
        spidPotionCount.text = hillPotion.ToString();
    }

    public void DrawFirePotionUI()
    {
        fireAspectPotionCount.text = unbornPotion.ToString();
    }

    public void DrawHipnosisPotionUI()
    {
        hipnosisPotionCount.text = hipnosisPotion.ToString();
    }

    public void DrawPoisonPotionUI()
    {
        poisonPotionCount.text = poisonPotion.ToString();
    }

    public void DrawHillPotionUI()
    {
        hillPotionCount.text = spidPotion.ToString();
    }


}
