using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public enum TriggerActionType
    {
        ToggleScoreUI,
        ResetScores   
    }

    public TriggerActionType actionType;

    public GameObject allScoreUI;

    public ScoreDisplay scoreDisplay;

    void Start()
    {
        if (actionType == TriggerActionType.ToggleScoreUI)
        {
            if (allScoreUI != null)
            {
                allScoreUI.SetActive(false);
            }
            else
            {
                Debug.LogWarning("allScoreUI가 할당되지 않았습니다!", this);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            switch (actionType)
            {
                case TriggerActionType.ToggleScoreUI:
                    if (allScoreUI != null)
                    {
                        allScoreUI.SetActive(true);
                    }
                    break;

                case TriggerActionType.ResetScores:
                    ScoreManager.instance.ResetAllScores();
                    scoreDisplay.UpdateScoreTexts();
                    break;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (actionType == TriggerActionType.ToggleScoreUI)
            {
                if (allScoreUI != null)
                {
                    allScoreUI.SetActive(false);
                }
            }
        }
    }
}