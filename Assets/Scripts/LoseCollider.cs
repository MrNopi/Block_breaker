using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    public static int lives;
    public LevelManager levelManager;
    Block_breaker Block;
    public GameObject ball;

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        Destroy(ball);
        // lives--;
        // GameObject go = Instantiate(Resources.Load("Ball")) as GameObject;   
        Brick.counter = 0;
          levelManager.LoadNextLevel(); 
    }
    private void Update()
    {
        
        
    }
}
