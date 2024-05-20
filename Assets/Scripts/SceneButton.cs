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
   
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            LevelController controller = new LevelController();
            controller.LoadSceneLevel();
        }
    }

    public void Interact()
    {
        LevelController controller = new LevelController();
        controller.LoadSceneLevel();
    }
}
