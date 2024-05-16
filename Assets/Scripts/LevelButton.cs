﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour, IInteractable
{

    public bool isOn;


    public string GetDescription()
   {
        if (isOn) return "Press E to go to next level";
        return "Locked";
   }
    public void Interact()
    {
        LevelController controller = new LevelController();
        controller.LoadNextLevel();
    }

}
