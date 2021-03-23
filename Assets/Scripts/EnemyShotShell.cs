﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotShell : MonoBehaviour
{
    public float shotSpeed;
    [SerializeField]
    private GameObject enemyShellPrefab;
    //private AudioClip shotSound;
    private int interval;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        interval += 1;
        
        if(interval % 60 == 0)
        {
            GameObject enemyShell = Instantiate(enemyShellPrefab, transform.position, Quaternion.identity);
            //enemyShell.GetComponent<Rigidbody>().AddForce(-enemyShell.transform.forward * shotSpeed);
        }
    }
}