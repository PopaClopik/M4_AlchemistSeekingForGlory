using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptCanvasController : MonoBehaviour
{
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


   public void CursorLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
