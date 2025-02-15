using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNav : MonoBehaviour
{
    [SerializeField]

    public void LoadNextScene()
    {
        GameManager.Instance.NextScene();
    }

    public void LoadStartScene()
    {
        GameManager.Instance.StartScene();

    }
}
