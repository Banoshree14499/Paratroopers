﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playscrpt : MonoBehaviour
{
    public GameObject plybtn,controls;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    public void play()
    {
        Time.timeScale = 1f;
        controls.SetActive(true);
        plybtn.SetActive(false);
    }
}