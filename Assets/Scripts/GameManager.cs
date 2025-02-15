// Written by Jay Gunderson
// 01/23/2025

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variables
    private static GameManager instance;
    private float playerScore = 0.0f;



    // Methods

    public void ResetScore()
    {
        playerScore = 0;
    }



    public static GameManager Instance
    {
        get 
        {
            if (instance == null)
            {
                GameObject aGameObject = new GameObject("Game Manager");
                instance = aGameObject.AddComponent<GameManager>();
                DontDestroyOnLoad(aGameObject);
            }
                return instance;
            
        }
        set { instance = value; }
    }
}
