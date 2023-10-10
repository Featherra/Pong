using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class paddle : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;
    public float maxValue = 3.8f;
    //find gameobjectText
    // gameObjectText.text = player1score + player2Score

    void paddleControl(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y < maxValue)
        {

            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
       
 
    }

  
    // Start is called before the first frame update
    void Update()
    {
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
      
                
    }
}
