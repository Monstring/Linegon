using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject walls;
    public int lvl = 1;

    public void OnDrawGizmos()
    {
        Vector3 screenSize = Camera.main.ViewportToWorldPoint(new Vector3(1,1,1));
        Gizmos.DrawWireCube(new Vector3(4,6.5f,0), new Vector3(screenSize.x, 1, 0));
    }

    // Use this for initialization
    void Start () {
        Instantiate(walls, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
