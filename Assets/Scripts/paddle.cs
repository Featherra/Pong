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

    void paddleControl(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y < maxValue)
        {

            Debug.Log("hi W");
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            Debug.Log("hi S");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
       
 
    }

  
    // Start is called before the first frame update
    void Start()
    {
        
    }
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
