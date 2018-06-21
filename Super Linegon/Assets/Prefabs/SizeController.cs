using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeController : MonoBehaviour {


    public float width = 8;
    public float height = 2;

    // Use this for initialization
    void Start () {
        transform.localScale = new Vector3(width, height, 0);
    }

    // Update is called once per frame
    void Update () {
    }
}
