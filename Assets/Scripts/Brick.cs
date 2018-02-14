 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public int maxHits ;
    int timesHit;
    int number;
    LevelManager levelManager;
    public static int counter;
	// Use this for initialization
	void Start () {
        maxHits = Random.Range(1, 4);
        timesHit = 0;
        counter++;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        Debug.Log(counter);
	}
    // Update is called once per frame
    void Update () {
        number = maxHits - timesHit;
        switch (number)
        {
            case 3:
                {
                    this.GetComponent<SpriteRenderer>().color = Color.red;
                    break;
                }
            case 2:
                {
                    this.GetComponent<SpriteRenderer>().color = Color.green;
                    break;
                }
            case 1:
                {
                    this.GetComponent<SpriteRenderer>().color = Color.yellow;
                    break;
                }
            case 0:
                {
                    counter--;
                    Destroy(this.gameObject);
                    levelManager.Break();
                    break;
                }

        }
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
    }
}
