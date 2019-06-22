﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class BulbControl : MonoBehaviour
{
    [Range(0f, 5f)]
    public float defaultIntensity;
    [Range(0f, 2f)]
    public float additionalIntensity;
    public float flickingSpeed = 1;
    private Light2D bulbLight;
    private float currentIntensity;

    // Start is called before the first frame update
    void Start()
    {
        bulbLight = GetComponent<Light2D>();
        currentIntensity = defaultIntensity;
    }

    // Update is called once per frame
    void Update()
    {
        currentIntensity = defaultIntensity;
        bulbLight.intensity = currentIntensity + additionalIntensity * Mathf.Sin(Time.time * flickingSpeed);
    }
}