using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
//For Random:
using System;

public class GridManager : MonoBehaviour {

    //Attributs
    [SerializeField] private bool isPlayer1Turn;
    [SerializeField] private bool isPlayer2Turn;
    
    private string field;

    //Methods

	// Use this for initialization
	void Start ()
    {

        select1stPlayer(); //Generate the 1st random player to play
        Debug.Log("player1Turn:" +isPlayer1Turn);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    //Get the random player to start:
    void select1stPlayer()
    {

        
        System.Random rnd = new System.Random();
        int playerSelector = rnd.Next(1, 3);
        if (playerSelector == 1)
            isPlayer1Turn = true;
        if (playerSelector == 2)
            isPlayer2Turn = true;

    }
    //Manage turns ( is attached to all buttons inspector)
    public void turnManager(Button currentB)
    {
        
        if (isPlayer1Turn)
        {
            
            currentB.GetComponentInChildren<Text>().text = "O";
            switchTurns();
        }
        else if (isPlayer2Turn)
        {
            currentB.GetComponentInChildren<Text>().text = "X";
            switchTurns();
        }
    }
    //Switch Player turns ( simple)
    void switchTurns( )
    {
        bool player;
        player = isPlayer1Turn;
        isPlayer1Turn = isPlayer2Turn;
        isPlayer2Turn = player;
        

    }

}
