// Written by Jay Gunderson
// 01/23/2025

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void AddScore(float aScore) 
    {
        playerScore += aScore;
        foreach( ScoreDisplay sd in FindObjectsOfType<ScoreDisplay>())
        {
            sd.ChangeScore();
        }
    }





    public void StartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void NextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if(nextScene >= SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(0);
        }
        else
        {

        }
    }
   
    public float PlayerScore { get { return playerScore; } }


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
