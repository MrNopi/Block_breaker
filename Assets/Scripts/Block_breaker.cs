using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block_breaker : LoseCollider
{
    public Canvas canv;
    public Text_prop text1;
    public Text_prop text2;
    private int score;
    public void LoadLevel(string level) {
        Application.LoadLevel(level);
    }

	// Use this for initialization
	void Start () {
        LoseCollider.lives = 3;
        Hide();
      //  text1 = gameObject.GetComponent<Text>();
        //text2 = gameObject.GetComponent<Text>();
       /* text1.fontSize=text1.fontSize / 1000000;
        text2.fontSize = text1.fontSize / 1000000;
        text1.text = "asdadfasd";
        */
    }
	
	// Update is called once per frame
	void Update () {
        if (lives == 0)
        {
            Show();
        }
    }
    public void Hide()
    {
        canv.enabled = false;

    }
    public void Show()
    {
        canv.enabled = true;
    }
}
