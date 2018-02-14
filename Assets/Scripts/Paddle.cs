using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    public bool autoPlay = false;
    private ball Ball;
	// Update is called once per frame
	void Update () {
        if (!autoPlay)
        {
            PlayerMove();
        }
        else
        {
            AutoPlay();
        }
    }

    private void Start()
    {
        Ball = GameObject.FindObjectOfType<ball>();
    }
    void PlayerMove()
    {
        Vector3 Pos = new Vector3(0f, this.transform.position.y, 0f);
        float PaddlePos = Input.mousePosition.x / Screen.width * 12;
        Pos.x = Mathf.Clamp(PaddlePos - 6.15f, -6.15f, 6.15f);
        this.transform.position = Pos;
    }
    void AutoPlay()
    {
        Vector3 Pos = new Vector3(0f, this.transform.position.y, 0f);
        Vector3 BallPosition = Ball.transform.position;
        Pos.x = Mathf.Clamp(BallPosition.x, -6.15f, 6.15f);
        this.transform.position = Pos;
    }
}
