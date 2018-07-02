using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public float speed = 5;
    public bool alive = true;

	// Use this for initialization
	void Start () {
        transform.GetChild(0).gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        alive = false;
        if (alive == false)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            gameObject.GetComponent<CharacterMovement>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void test()
    {
        alive = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        gameObject.GetComponent<CharacterMovement>().enabled = true;
        transform.GetChild(0).gameObject.SetActive(false);
        print("button is pressed");
    }

}