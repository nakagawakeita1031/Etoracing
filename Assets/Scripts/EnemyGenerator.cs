﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject[] EnemyObjPrefabs;
    public float EnemyApperTime;
    private float CountUpTimer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CountUpTimer += Time.deltaTime;

        if (EnemyApperTime < CountUpTimer)
        {
            CountUpTimer = 0;
            int index = Random.Range(0, EnemyObjPrefabs.Length - 1);
            GameObject Enemy = Instantiate(EnemyObjPrefabs[index], transform.position, Quaternion.identity);
        }
    }
}