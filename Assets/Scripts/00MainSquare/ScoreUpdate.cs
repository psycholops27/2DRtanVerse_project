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

   
    private void OnEnable() // OnEnable() �Լ��� �� ��ũ��Ʈ�� �پ��ִ� GameObject�� SetActive(true)�� 'Ȱ��ȭ'�� ������ �ڵ����� ȣ��
    {
        UpdateScoreTexts();
    }

    public void UpdateScoreTexts()
    {
        if (ScoreManager.instance == null)
        {
            Debug.LogError("ScoreManager.instance�� ã�� �� �����ϴ�!");
            return;
        }

        flappyHighScoreText.text = ScoreManager.instance.highScoreFP.ToString();
        flappyLastScoreText.text = ScoreManager.instance.lastScoreFP.ToString();
        stackHighScoreText.text = ScoreManager.instance.highScoreTS.ToString();
        stackLastScoreText.text = ScoreManager.instance.lastScoreTS.ToString();
    }
}
