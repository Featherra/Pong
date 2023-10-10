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

    void resetBall()
    {
        xPosition = 0f;
        yPosition = Random.Range(-4f, 4f);
        xSpeed = xSpeed * 1f;
    }
    // Start is called before the first frame update
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
            scoreText.text = "Left player has won!";
            xPosition = 0f;
            yPosition = 0f;
        } else if (rightScore >= 5)
        {
            scoreText.text = "Right player has won!";
            xPosition = 0f;
            yPosition = 0f;
        }
   }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;
        } else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalL"))
        {
            resetBall();
            rightScore++;
            scoreText.text = leftScore + " - " + rightScore;
        }
        else if (collision.gameObject.CompareTag("verticalR"))
        {
            resetBall();
            leftScore++;
            scoreText.text = leftScore + " - " + rightScore;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.1f;
        }

                
    }

}
