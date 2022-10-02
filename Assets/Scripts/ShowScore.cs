using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText = scoreText.GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + (int)ScoreManager.Instance.displayScore;
    }
}
