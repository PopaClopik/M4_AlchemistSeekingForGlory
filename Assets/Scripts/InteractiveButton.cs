using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveButton : MonoBehaviour
{
    public GameObject targetCanvas;
    private bool isPlayerInRange = false;
    public GameObject _cookingClue;

    void Start()
    {
        if (targetCanvas != null)
        {
            targetCanvas.SetActive(false); // Начально Canvas выключен
        }
    }

    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (targetCanvas != null)
            {
                _cookingClue.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                targetCanvas.SetActive(true); // Включаем Canvas при нажатии клавиши E
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _cookingClue.SetActive(true);
            isPlayerInRange = true;
            // Вы можете добавить визуальные подсказки, например, отобразить текст "Нажмите E для взаимодействия"
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _cookingClue.SetActive(false);
            isPlayerInRange = false;
            // Скрыть визуальные подсказки
        }
    }
}

