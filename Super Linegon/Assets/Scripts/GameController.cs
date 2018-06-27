﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public int score;
    public float width;
    public float height;
    public int level;

    public SpawnerController SpawnerController;
	// Use this for initialization
	void Start () {
        score = 0;
        level = 3;
        SpawnerController.InitiateSpawn(new Vector2(width, height), level);
	}
	
	// Update is called once per frame
	void Update () {
        score += 9;
        CalculateLevel();
	}

    public void CalculateLevel()
    {
        int pLevel = level;
        level = 3 + (score / 5000);
        if (level != pLevel)
        {
            SpawnerController.InitiateSpawn(new Vector2(width, height), level);
        }
    }
}