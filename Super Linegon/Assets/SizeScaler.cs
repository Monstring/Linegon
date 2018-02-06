using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeScaler : MonoBehaviour {

    Spawner spawn = new Spawner();

	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(spawn.width,spawn.height,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
