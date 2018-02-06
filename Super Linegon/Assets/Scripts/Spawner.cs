using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject walls;
    public int lvl = 5;
    public float spawnDelay = 1;

    public float width = 8;
    public float height = 2;


    // Use this for initialization
    void Start () {
        StartCoroutine (timer());
    }

    // Update is called once per frame
    void Update () {

	}

    IEnumerator timer()
    {
        for (int i = 0; i < lvl; i++)
        {
            Instantiate(walls, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(spawnDelay);
    }

}
