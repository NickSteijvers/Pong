using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paddle : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;
    public float maxValue = 3.8f;

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
        else if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
   


    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        { 
            paddleControl(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            paddleControl (KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
