using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour {

    private void OnDrawGizmos()
    {
        Vector3 screenSize = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 1));
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
