﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject[] enemy;
    public float positionX, positionY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            SpawnEnemy();
        }

    }

    void SpawnEnemy()
    {
        positionX = Random.Range(19.5f, 20.5f);
        positionY = Random.Range(-2.75f, -3.75f);

        var newEnemy = Instantiate(enemy[Random.Range(0, enemy.Length)]);
        newEnemy.transform.position = new Vector3(positionX, positionY, 0);
    }
}
