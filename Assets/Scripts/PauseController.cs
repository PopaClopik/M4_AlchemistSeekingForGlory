﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scaledTimer;
    [SerializeField] TextMeshProUGUI _unscaledTimer;

    [SerializeField] GameObject _pausePanel;

    bool _isPaused = false;

    float _scaledTime;
    float _unscaledTime;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        UpdateTimers();
    }


    void UpdateTimers()
    {
        _scaledTime += Time.deltaTime;
        _unscaledTime += Time.unscaledDeltaTime;

        _scaledTimer.text = "Scaled Time: " + _scaledTime.ToString("F2");
        _unscaledTimer.text = "Unscaled Time: " + _unscaledTime.ToString("F2");
    }

    public void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
       // GetComponent<StonesCaster>().enabled = false;

        _pausePanel.SetActive(true);
        Time.timeScale = 0;
        _isPaused = true;
    }

    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
       // GetComponent<StonesCaster>().enabled = true;

        _pausePanel.SetActive(false);
        Time.timeScale = 1;
        _isPaused = false;
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1;
        _isPaused = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
    }
}
