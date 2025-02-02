﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public float rate;
    public GameObject[] enemies;
    public int waves = 1;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", rate, rate);
    }

    void SpawnEnemy()
    {
        for(int i=0; i<waves;i++)
        Instantiate(enemies[(int)UnityEngine.Random.Range(0, enemies.Length)], new Vector3(UnityEngine.Random.Range(-2.8f, 2.8f), 7, 0), Quaternion.identity);
    }

}