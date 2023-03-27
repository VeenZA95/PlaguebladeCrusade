using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //Scene Handler

    //Start Game
    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }
        
    //End Game

    //Restart Game

}
