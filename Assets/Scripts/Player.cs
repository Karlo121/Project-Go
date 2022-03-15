using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    // References
    public GameObject controller;
    public GameObject placeStone;

    // Positions
    private int xBoard = -1;
    private int yBoard = -1;

    // Player variable
    private string player;

    // References for all sprites
    public Sprite whiteStone, blackStone;


    public void Activate() {
        controller = GameObject.FindGameObjectWithTag("GameController");
        
        //Chaning coords of an object
        SetCoords();

        switch (this.name) {
            case "black": 
                this.GetComponent<SpriteRenderer>().sprite = blackStone;
                break;
            case "white":
                this.GetComponent<SpriteRenderer>().sprite = whiteStone;
                break;
        }
    }

    public void SetCoords() {
        float x = xBoard;
        float y = yBoard;

        x *= 0.66f;
        y *= 0.66f;

        x += -2.3f;
        y += -2.3f;

        this.transform.position = new Vector3(x,y,-1.0f);
    }
}
