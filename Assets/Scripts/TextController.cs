using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    public Text text;
    private enum States
        
        {sheets_0,
        cell,
        lock_0,
        mirror,
        cell_mirror,
        sheets_1,
        lock_1,
        freedom
    }
    bool pause = true;
    private States Mystate;
    int choice;
    bool Pause(float time)
    {
      
        while (time!=0)
        {
            time-=Time.deltaTime;
            print(time);
        }
        pause = false;
        return pause;
        
    }
	// Use this for initialization
	void Start () {
        Mystate = States.cell;
	}
    private void Choice()
    {
        choice = Random.Range(0, 5);
        //text.text = "Hello, what`s up";
        switch (choice)
        {
            case 1:
                text.text = "You'r looser";
                break;
            case 2:
                text.text = "You'r winner";
                break;
            case 3:
                text.text = "You right";
                break;
            case 4:
                text.text = "You wrong";
                break;
        }
    }

    void Update()
    {
        print(Mystate);
        if (Mystate == States.cell)
        {
            State_cell();
        }
        if (Mystate == States.mirror)
        {
            State_mirror();
        }
        if (Mystate == States.sheets_0)
        {
            State_sheets_0();
        }
        if (Mystate == States.lock_0)
        {
            State_lock_0();
        }
        if (Mystate == States.lock_1)
        {
            State_lock_1();
        }
        if (pause == false && Mystate == States.cell_mirror)
        {
            State_cell_mirror();
        }
        if (Mystate == States.freedom)
        {
            State_freedom();
        }
        if (Mystate == States.sheets_1)
        {
            State_sheets_1();
        }
        //   Debug.Log(Mystate);
    }
    private void State_lock_0()
    {
        text.text = "R for return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            Mystate = States.cell;
        }
    }
    private void State_cell()
    {
        text.text = "S for Sheets , L for Lock, M for mirror";

        if (Input.GetKeyDown(KeyCode.S))
        {
            Mystate = States.sheets_0;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Mystate = States.lock_0;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Mystate = States.mirror;
        }
    }
    private void State_sheets_0()
    {
        text.text = "R for cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            Mystate = States.cell;
        }
    }
    private void State_mirror()
    {
        
        text.text = "R for return, C for Cell_mirror";
        Pause(5);
        if (pause == false && Input.GetKeyDown(KeyCode.R))
        {
            Mystate = States.cell;

        }
        if (pause == false && Input.GetKeyDown(KeyCode.C))
        {
            Mystate = States.cell_mirror;

        }
   
   
    }
    private void State_cell_mirror()
    {
        text.text = "S for sheets_1, R for return, L for lock_1";
        if (Input.GetKeyDown(KeyCode.L))
        {
            Mystate = States.lock_1;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Mystate = States.mirror;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Mystate = States.sheets_1;
        }
        Pause(5);
    }
    private void State_sheets_1()
    {
        text.text = "R for return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            Mystate = States.cell_mirror;
        }


    }
    private void State_lock_1()
    {
        text.text = "F for freedom and end of the game , or R for return";
        if (Input.GetKeyDown(KeyCode.F))
        {
            Mystate = States.freedom;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Mystate = States.cell_mirror;

        }

    }
    private void State_freedom() {
        text.text = "You are free now, and can do whatever you want";
    }

	}

