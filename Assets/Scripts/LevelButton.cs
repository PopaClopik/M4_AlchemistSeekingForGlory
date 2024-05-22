using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomButton : MonoBehaviour, IInteractable
{

    public bool isOn;
    public PlayerInteraction pl1;
    public PlayerInteraction1 pl2;
    public GameObject player;

    public string GetDescription()
   {
        if (isOn) return "Press E to go inside";
        return "Locked";
   }
    public void Interact()
    {
        pl1.enabled = true;
        pl2.enabled = false;

        LevelController controller = new LevelController();
        controller.LoadRoomLevel();
    }

}
