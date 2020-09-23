﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObjectsSpawnManager : MonoBehaviour
{
    [SerializeField]
    GameObject _itemToBeSpawn;

    [SerializeField]
    GameObject[] _obstaclesToBeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnItem", 2.0f);
        Invoke("SpawnObstacle", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnItem()
    {
        GameObject go = Instantiate(_itemToBeSpawn, 
    }

    void SpawnObstacle()
    {
        int obsIdx = Random.Range(0, _obstaclesToBeSpawn.Length);
        GameObject go = Instantiate(_obstaclesToBeSpawn[obsIdx],

        float nextSpawnTime = Random.Range(0.2f, 1);
        Invoke("SpawnObstacle", nextSpawnTime);
    }
}