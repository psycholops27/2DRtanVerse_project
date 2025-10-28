using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum UIState
{
    Home,
    Game,
    Score,
}

public class TSUIManager : MonoBehaviour
{
    public StackManager stackManager;

    public HomeUI homeUI;
    public GameUI gameUI;
    public ScoreUI scoreUI;

    UIState currentState = UIState.Home;

    private void Awake()
    {
        homeUI?.Init(this);
        gameUI?.Init(this);
        scoreUI?.Init(this);

        ChangeState(UIState.Home);
    }

    public void ChangeState(UIState state)
    {
        currentState = state;
        homeUI?.SetActive(currentState);
        gameUI?.SetActive(currentState);
        scoreUI?.SetActive(currentState);
    }

    public void OnClickStart()
    {
        stackManager.Restart();
        ChangeState(UIState.Game);
    }

    public void OnClickExit()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("00MainSquareScene");
    }

    public void UpdateScore()
    {
        gameUI?.SetUI(stackManager.Score, stackManager.Combo, stackManager.MaxCombo);
    }

    public void SetScoreUI()
    {
        scoreUI.SetUI(stackManager.Score, stackManager.MaxCombo, stackManager.BestScore, stackManager.BestCombo);
        ChangeState(UIState.Score);
    }
}
