using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;
    public TMP_Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        xPosition = xPosition + xSpeed * Time.deltaTime; // this is the x position of the ball
        //xposition += xSpeed * Time.deltaTime; shorter way to do the same thing
        yPosition = yPosition + ySpeed * Time.deltaTime; //this is the y position of the ball
        transform.position = new Vector3(xPosition, yPosition, 0f);


    }
}
