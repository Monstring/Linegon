using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : SizeController {

    public GameObject walls;
    public int lvl = 3;
    public float spawnDelay = 1;

    float initialX = 4;
    float initialY = 6;


    // Use this for initialization
    void Start () {
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update () {

    }

    IEnumerator timer()
    {
        while (true)
        {
            width /= 3;
            for (int i = 0; i < 1; i++)
            {
                Instantiate(walls, new Vector3(initialX,initialY,0), Quaternion.identity);
            }
        yield return new WaitForSeconds(spawnDelay);
        }
    }

}
