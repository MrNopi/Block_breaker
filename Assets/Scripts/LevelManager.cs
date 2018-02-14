using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void Break()
    {
        if (Brick.counter < 1)
        {
            LoadNextLevel();
        }
    }
    public void StartNewGame()
    {
        Application.LoadLevel(1);
    }
}
