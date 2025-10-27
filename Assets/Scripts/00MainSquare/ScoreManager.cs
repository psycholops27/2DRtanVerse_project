using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    // Flappy Plane
    public int lastScoreFP = 0;
    public int highScoreFP = 0;
    private const string LastScoreFPKey = "LastScoreFP";
    private const string HighScoreFPKey = "HighScoreFP";

    // The Stack
    public int lastScoreTS = 0;
    public int highScoreTS = 0;
    public int bestComboTS = 0;
    private const string LastScoreTSKey = "LastScoreTS";
    private const string HighScoreTSKey = "HighScoreTS";
    private const string BestComboTSKey = "BestComboTS";

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Flappy Plane
        lastScoreFP = PlayerPrefs.GetInt(LastScoreFPKey, 0);
        highScoreFP = PlayerPrefs.GetInt(HighScoreFPKey, 0);

        // The Stack
        lastScoreTS = PlayerPrefs.GetInt(LastScoreTSKey, 0);
        highScoreTS = PlayerPrefs.GetInt(HighScoreTSKey, 0);
        bestComboTS = PlayerPrefs.GetInt(BestComboTSKey, 0);

    }

    
    public void SetLastScoreFP(int score)
    {
        lastScoreFP = score;
        PlayerPrefs.SetInt(LastScoreFPKey, lastScoreFP);
        PlayerPrefs.Save();
    }

    public void UpdateHighScoreFP(int newScoreFP)
    {
        if (newScoreFP > highScoreFP)
        {
            highScoreFP= newScoreFP;
            PlayerPrefs.SetInt(HighScoreFPKey, highScoreFP);
            PlayerPrefs.Save();
        }
    }

    public void SetLastScoreTS(int score)
    {
        lastScoreTS = score;
        PlayerPrefs.SetInt(LastScoreTSKey, lastScoreTS);
        PlayerPrefs.Save();
    }

    public void UpdateHighScoreTS(int newScoreTS, int newMaxCombo)
    {
        bool newRecord = false;

        if (newScoreTS > highScoreTS)
        {
            highScoreTS = newScoreTS;
            PlayerPrefs.SetInt(HighScoreTSKey, highScoreTS);
            newRecord = true;
        }

        if (newMaxCombo > bestComboTS)
        {
            bestComboTS = newMaxCombo;
            PlayerPrefs.SetInt(BestComboTSKey, bestComboTS);
            newRecord = true;
        }

        if (newRecord)
        {
            PlayerPrefs.Save();
        }
    }


    public void ResetAllScores()
    {
        lastScoreFP = 0;
        highScoreFP = 0;

        lastScoreTS = 0;
        highScoreTS = 0;
        bestComboTS = 0;

        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
}