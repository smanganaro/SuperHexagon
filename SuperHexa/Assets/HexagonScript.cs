﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonScript : MonoBehaviour
{
    public Rigidbody2D rd;

    public float shrinkSpeed = 03f;


    // Start is called before the first frame update
    void Start()
    {
        rd.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if (transform.localScale.x <= 0.05f){
        	Destroy(gameObject);
        }
    }
}
