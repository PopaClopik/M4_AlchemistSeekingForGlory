using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneButton : MonoBehaviour, IInteractable
{
    public bool isOn;


    public string GetDescription()
    {
        if (isOn) return "Press E";
        return "Locked";
    }

    public void Interact()
    {
        LevelController controller = new LevelController();
        controller.LoadSceneLevel();
    }
}
