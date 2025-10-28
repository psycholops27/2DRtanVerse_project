using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreUpdate : MonoBehaviour
{
    public TextMeshProUGUI flappyHighScoreText;
    public TextMeshProUGUI flappyLastScoreText;
    public TextMeshProUGUI stackHighScoreText;
    public TextMeshProUGUI stackLastScoreText;

   
    private void OnEnable() // OnEnable() 함수는 이 스크립트가 붙어있는 GameObject가 SetActive(true)로 '활성화'될 때마다 자동으로 호출
    {
        UpdateScoreTexts();
    }

    public void UpdateScoreTexts()
    {
        if (ScoreManager.instance == null)
        {
            Debug.LogError("ScoreManager.instance를 찾을 수 없습니다!");
            return;
        }

        flappyHighScoreText.text = ScoreManager.instance.highScoreFP.ToString();
        flappyLastScoreText.text = ScoreManager.instance.lastScoreFP.ToString();
        stackHighScoreText.text = ScoreManager.instance.highScoreTS.ToString();
        stackLastScoreText.text = ScoreManager.instance.lastScoreTS.ToString();
    }
}
