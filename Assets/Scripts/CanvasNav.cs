using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNav : MonoBehaviour
{
    [SerializeField]

    public void LoadNextScene(int anIDX)
    {
        SceneManager.LoadScene(anIDX);
    }

    public void LoadStartScene()
    {
        LoadNextScene(0); 
    }
}
