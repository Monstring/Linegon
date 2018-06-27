using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

    public float delay;
    public Spawner spawnerPrefab;

    private Spawner[] spawners;
    public void Start()
    {
        spawners = new Spawner[0];
    }
    public void InitiateSpawn(Vector2 bounds, int level)
    {
        //number of spawns
        spawners = new Spawner[level];
        for (int i = 0; i < level; i++)
        {
            float spawnerWidth = bounds.x/level;
            float x = (spawnerWidth)*i + (spawnerWidth/2);
            Vector3 pos = new Vector2(x, bounds.y);
            spawners[i] = Instantiate(spawnerPrefab, pos, Quaternion.identity);
            //scale change
            spawners[i].transform.localScale = new Vector3(1f/level, 1, 1);
        }
        //start courotine
    }
    public void test()
    {
        InitiateSpawn(new Vector2(8,6), 4);
        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i].Spawn();
        }
    }
}
