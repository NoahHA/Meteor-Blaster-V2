using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    void Update()
    {
        int yRange = 12;

        if (transform.position.y > yRange)
            Destroy(gameObject);
    }
}
