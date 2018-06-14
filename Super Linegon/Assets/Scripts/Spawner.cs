using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject walls;
    public int lvl = 5;
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
        int WallNumber = 1;
        while (true)
        {
            for (int i = 0; i < lvl; i++)
            {
                Instantiate(walls, new Vector3(initialX,initialY,0), Quaternion.identity);
            }
            WallNumber++;
            print(WallNumber);
        yield return new WaitForSeconds(spawnDelay);
        }
    }

}
