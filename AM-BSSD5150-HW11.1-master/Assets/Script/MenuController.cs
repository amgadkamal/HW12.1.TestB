﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void loadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void loadGame()
    {
        SceneManager.LoadScene("Main");
    }
    
    
    
}
