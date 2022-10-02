using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMeteor : MonoBehaviour
{
    void Start()
    {
        // randomly rotate meteor
        Vector3 randomRotation = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        transform.Rotate(randomRotation);

        // randomly scale meteor
        float maxScaleFactor = 2.0f;
        float randomScale = Random.Range(1 / maxScaleFactor, maxScaleFactor);
        transform.localScale = new Vector3(randomScale, randomScale, randomScale);
    }

    // Update is called once per frame
    void Update()
    {
        // spin meteor
        float minRotationSpeed = 10.0f;
        float maxRotationSpeed = 100.0f;
        float rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
        Vector3 rotationAxis = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));

        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}