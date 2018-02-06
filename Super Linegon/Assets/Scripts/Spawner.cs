using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject walls;
    public int lvl = 1;

    public float width = 8;
    public float height = 1;


    // Use this for initialization
    void Start () {
        Spawn();
    }

    // Update is called once per frame
    void Update () {

	}

    void Spawn()
    {

        for (int i = 0; i < lvl; i++)
        {
            Instantiate(walls, transform.position, Quaternion.identity);
        }
    }
}
