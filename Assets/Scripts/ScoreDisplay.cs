using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] protected TMP_Text scoreText;
    [SerializeField] protected string preText = "Score: ";
    [SerializeField] protected string postText = " pts";

    public void Start()
    {
        ChangeScore();
    }

    public void ChangeScore()
    {
       scoreText.text = preText + GameManager.Instance.PlayerScore + postText;
    }
}
