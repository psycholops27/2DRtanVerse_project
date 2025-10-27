using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPGameManager : MonoBehaviour
{
    public FPUIManager uiManager;

    public bool isGameOver = false;
    public bool isGameStarted = false;

    private int currentScore = 0;
    private int highScore = 0;
    private int lastScore = 0;


    private void Awake()
    {
        if (ScoreManager.instance != null)
        {
            highScore = ScoreManager.instance.highScoreFP;
            lastScore = ScoreManager.instance.lastScoreFP;
        }
        else
        {
            Debug.LogError("ScoreManager not found!");
        }

        Time.timeScale = 0f;
    }

    public void Start()
    {
        uiManager.UpdateScore(0);
        uiManager.UpdateHighScore(highScore);
    }

    public void StartGame()
    {
        isGameStarted = true;
        isGameOver = false;
        Time.timeScale = 1f;

        uiManager.ShowGameUI();
    }

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);

        if (currentScore > highScore)
        {
            highScore = currentScore;
            uiManager.UpdateHighScore(highScore);

            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.UpdateHighScoreFP(highScore);
            }
        }
    }

    public void GameOver()
    {
        isGameOver = true;

        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.SetLastScoreFP(currentScore);
        }

        uiManager.ShowGameOverUI();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("01FlappyPlaneScene");
    }

    public void ExitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("00MainSquareScene");
    }
}