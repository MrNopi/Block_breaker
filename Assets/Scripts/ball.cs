using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public Paddle paddle;
    private Vector3 PaddleToBallVector;
    private bool hasStarted = false;
    private void Start()
    {
        GetComponent<Rigidbody2D>();
        PaddleToBallVector = this.transform.position - paddle.transform.position;
    }
    void Update()
    {
      //  Vector3 direction = transform.right * Input.GetAxis("Vertical");
      if(!hasStarted)
        this.transform.position = paddle.transform.position + PaddleToBallVector;

        if (Input.GetMouseButton(0))
        {
            hasStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);
        }
    }

}
