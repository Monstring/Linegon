using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public SizeController walls;
    public int lvl = 3;
    public float spawnDelay = 1;

    float initialX = 4;
    float initialY = 6;


    // Use this for initialization
    void Start () {
        
        lvl = 3;
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update () {

    }

    IEnumerator timer()
    {
        var rt = walls.GetComponent<SpriteRenderer>();
        while (true)
        {

            float wallWidth = 8f / lvl;
            print(rt.bounds.size.x);
            for (int i = 0; i < lvl; i++)
            {
               SizeController s = Instantiate(walls, new Vector3(GetWallPosition(wallWidth, i),initialY,0), Quaternion.identity);
               s.transform.localScale = new Vector2(wallWidth, s.transform.localScale.y);
            }
        yield return new WaitForSeconds(spawnDelay);
        }
    }

    private float GetWallPosition(float wallWidth, int i) {

        return (wallWidth * i) + (wallWidth/2);
    }

}
