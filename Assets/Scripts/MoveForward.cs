using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // move down the screen at a constant rate
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}
