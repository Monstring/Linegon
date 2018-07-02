using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public int score;
    public float width;
    public float height;
    public int level;
    public int scoreIncrement = 1;
    private int highScore;
    public Text scoreText;
    public CharacterMovement characterMovement;

    public SpawnerController SpawnerController;
	// Use this for initialization
	void Start () {
        score = 0;
        level = 3;
        SpawnerController.InitiateSpawn(new Vector2(width, height), level);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "High score: " + highScore.ToString() + "\n" + score.ToString();
        if (characterMovement.alive == true)
        {
            score += scoreIncrement;
        }
        CalculateLevel();
        if (score > highScore)
        {
            highScore = score;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Retry();
        }
	}
    public void CalculateLevel()
    {
        int pLevel = level;
        level = 3 + (score / 5000);
        if (level != pLevel)
        {
            SpawnerController.InitiateSpawn(new Vector2(width, height), level);
        }
    }
    public void Retry()
    {
        score = 0;
        characterMovement.alive = true;
        characterMovement.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        characterMovement.gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        characterMovement.gameObject.GetComponent<CharacterMovement>().enabled = true;
        characterMovement.transform.GetChild(0).gameObject.SetActive(false);
    }
}
