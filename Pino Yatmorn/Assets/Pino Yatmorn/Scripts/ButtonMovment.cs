using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovment : TouchManger {
    public float moveSpeed = 5.0f,jumpHeight = 3.0f;
    public GameObject player = null;
    public enum Direction {Up,Down,Left,Right}
    public Direction MovementDirection = new Direction();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TouchInput();
	}

    void OnFisrtTouchBegan()
    {
        switch (MovementDirection)
        {
            case Direction.Up:
                player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight * Time.deltaTime);
                player.GetComponent<Animator>().SetInteger("State", 0);
                break;
        }
    }
    void OnSecondTouchBegan()
    {
        switch (MovementDirection)
        {
            case Direction.Up:
                player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight * Time.deltaTime);
                break;
        }
    }
    void OnFirstTouch()
    {
        switch (MovementDirection)
        {
            case Direction.Down:
                break;
            case Direction.Left:
                player.transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
                player.GetComponent<Animator>().SetInteger("State", 1);
                break;
            case Direction.Right:
                player.GetComponent<Animator>().SetInteger("State", 1);
                player.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                break;
        }
    }
    void OnSecondTouch()
    {
        switch (MovementDirection)
        {
            case Direction.Down:
                break;
            case Direction.Left:
                player.transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
                break;
            case Direction.Right:
                player.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                break;
        }



    }
}
