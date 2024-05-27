using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestChecker : MonoBehaviour
{
    public string sceneNameToLoad = "VillageScene";

    public InventoryAlter InventoryAlter;
    public GameObject QuestSpenser11;
    public GameObject QuestSpenser22;
    public GameObject QuestSpenser3;
    public GameObject QuestSpenser4;

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == sceneNameToLoad)
        {
            if(InventoryAlter.Quest1Done == true)
            {
                QuestSpenser22.SetActive(true);
                QuestSpenser11.SetActive(false);
            }
            if(InventoryAlter.Quest1Done == true && InventoryAlter.Quest2Done == true)
            {
                QuestSpenser11.SetActive(false);
                QuestSpenser22.SetActive(false);
                QuestSpenser3.SetActive(true);

            }
            if (InventoryAlter.Quest1Done == true && InventoryAlter.Quest2Done == true && InventoryAlter.Quest3Done == true)
            {
                QuestSpenser11.SetActive(false);
                QuestSpenser22.SetActive(false);
                QuestSpenser3.SetActive(false);
                QuestSpenser4.SetActive(true);
            }
            if (InventoryAlter.Quest1Done == true && InventoryAlter.Quest2Done == true && InventoryAlter.Quest3Done == true && InventoryAlter.Quest4Done == true)
            {
                QuestSpenser11.SetActive(false);
                QuestSpenser22.SetActive(false);
                QuestSpenser3.SetActive(false);
                QuestSpenser4.SetActive(false);
            }

            Debug.Log("Сцена " + sceneNameToLoad + " была загружена.");
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
