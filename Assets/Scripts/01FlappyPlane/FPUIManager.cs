using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class FPUIManager : MonoBehaviour
{
    public GameObject TitleText;
    public GameObject scoreObject;
    public TextMeshProUGUI scoreText;
    public GameObject highScoreObject;
    public TextMeshProUGUI highScoreText;
    public GameObject startButton;
    public GameObject exitButton;
    public GameObject restartButton;

    private void Awake()
    {

    }

    void Start()
    {
        TitleText.SetActive(true);
        startButton.SetActive(true);
        exitButton.SetActive(true);
        restartButton.SetActive(false);
        scoreObject.SetActive(false);
        highScoreObject.SetActive(false);
    }

    public void ShowGameUI()
    {
        TitleText.SetActive(false);
        startButton.SetActive(false);
        exitButton.SetActive(false);
        scoreObject.SetActive(true);
        highScoreObject.SetActive(true);
    }

    public void ShowGameOverUI()
    {
        restartButton.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text= score.ToString();
    }

    public void UpdateHighScore(int score)
    {
        highScoreText.text= score.ToString();
    }

}
