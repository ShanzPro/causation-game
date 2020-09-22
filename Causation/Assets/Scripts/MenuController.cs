﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(4);
    }

    public void TestLevel()
    {
        SceneManager.LoadScene(3);
    }

    public void CreditsScreen()
    {
        SceneManager.LoadScene(6);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}