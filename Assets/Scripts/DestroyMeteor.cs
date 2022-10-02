using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeteor : MonoBehaviour
{

    void Update()
    {
        int yRange = 15;

        if (transform.position.y < -yRange)
        {
            Destroy(gameObject);
            ScoreManager.Instance.score -= ScoreManager.Instance.missMeteorPenalty;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        ScoreManager.Instance.score += ScoreManager.Instance.pointsPerMeteor;
    }

}
