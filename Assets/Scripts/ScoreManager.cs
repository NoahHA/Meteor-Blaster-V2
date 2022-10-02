using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public float score;
    public float displayScore;
    public float transitionSpeed = 100;
    public float pointsPerMeteor = 50.0f;
    public float pointsPerSecond = 1.0f;
    public float missMeteorPenalty = 100.0f;

    private void Update()
    {
        score += Time.deltaTime * pointsPerSecond;
        displayScore = Mathf.MoveTowards(displayScore, score, transitionSpeed * Time.deltaTime);
    }

    private void Awake()
    {
        Instance = this;
    }
}
