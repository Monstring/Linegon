using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject fallingWalls;

    public void Spawn()
    {
        Instantiate(fallingWalls, this.transform).transform.localPosition = Vector3.zero;
    }
}
