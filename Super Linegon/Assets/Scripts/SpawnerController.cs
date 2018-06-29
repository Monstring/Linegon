using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

    public float delay;
    public Spawner spawnerPrefab;
    private Spawner[] spawners;
    public Coroutine spawningCoroutine;

    public void Start()
    {
        spawners = new Spawner[0];
    }
    public void InitiateSpawn(Vector2 bounds, int level)
    {
        if (spawningCoroutine != null)
        {
            StopCoroutine(spawningCoroutine);
            //TODO stop spawning new spawn points
        }
        if (spawners.Length != level) {
            //number of spawns
            spawners = new Spawner[level];
            for (int i = 0; i < level; i++)
            {
                spawners[i] = Instantiate(spawnerPrefab);
            }
        }
        float spawnerWidth = bounds.x/level;
        for (int i = 0; i < level; i++)
        {
            float x = (spawnerWidth) * i + (spawnerWidth / 2);
            Vector3 pos = new Vector2(x, bounds.y);
            spawners[i].transform.position = pos;
            spawners[i].transform.localScale = new Vector3(1f / level, 1, 1);
        }
        spawningCoroutine = StartCoroutine(StartSpawning());
    }
    IEnumerator StartSpawning() {
        while (true)
        {
            RandomSpawner();   
            yield return new WaitForSeconds(delay);
        }
    }
    public void test()
    {
        InitiateSpawn(new Vector2(8, 6), 4);


        //randomly select a spawner and make it spawn. 
        //for (int i = 0; i < spawners.Length; i++)
        //{
        //    spawners[i].Spawn();
        //}
    }

    private void RandomSpawner()
    {
        int wallNumbers = Random.Range(1, spawners.Length);
        for (int i = 0; i < wallNumbers; i++)
        {
            spawners[Random.Range(0, spawners.Length)].Spawn();
        }
    }
}
