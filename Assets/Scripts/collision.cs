using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collision : MonoBehaviour
{
    public float xPosition = -2f;
    public float yPosition = -2f;
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    public TMP_Text scoreText;
    public int leftScore = 0;
    public int rightScore = 0;
    public int winScore = 5;

    void resetBall()   // position of the ball
    {
        xPosition = 0f;
        yPosition = Random.Range(-4f, 4f);   // if the ball hits a side it resets to a random position
        xSpeed = xSpeed * 1f;
    }
    
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        xPosition = xPosition + xSpeed * Time.deltaTime;
        //xposition += xSpeed * Time.deltaTime; shorter way to do the same thing
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
        if (leftScore >= 5)
        {
            scoreText.text = "Left player has won!"; // after the left person has scored 5 points this is shown
            xPosition = 0f;
            yPosition = 0f;  //position of the ball = in the middle
        } else if (rightScore >= 5)
        {
            scoreText.text = "Right player has won!";  // after the right person has scored 5 points this is shown
            xPosition = 0f;   //position of the ball = in the middle
            yPosition = 0f;
        }
   }
    private void OnTriggerEnter2D(Collider2D collision)  //what happens when the ball hits the wall
    {
        if(collision.gameObject.CompareTag("horizontalWall")) 
        {
            ySpeed = ySpeed * -1f;
        } else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalL")) // if u hit the left wall the right person gets a point
        {
            resetBall();
            rightScore++; // this adds a point to the score text for the left person
            scoreText.text = leftScore + " - " + rightScore;
        }
        else if (collision.gameObject.CompareTag("verticalR")) //if u hit the right wall the left person gets a point
        {
            resetBall(); 
            leftScore++;  // this adds a point to the score text for the right person
            scoreText.text = leftScore + " - " + rightScore;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.1f;
        }

                
    }

}
