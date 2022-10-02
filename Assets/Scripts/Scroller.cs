using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    public float speed;
    Material material;
    private Vector2 offset;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }
    private void Start()
    {
        offset = new Vector2(0, speed);
    }
    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}