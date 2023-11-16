using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UIElements;
using UnityEngine.UI;
using JetBrains.Annotations;
using TMPro;
using System.Runtime.CompilerServices;

public class AIPaddle : MonoBehaviour
{
    //variables
    public float yPosition = 2f;
    public float ySpeed = 2f;


    /// <summary>
    /// decides the position of the AI paddle
    /// </summary>
    void Start()
    {
        transform.position = new Vector3(8f, yPosition, 0f);
    }

    /// <summary>
    /// makes it so that the paddle follows the ball
    /// </summary>
    void Update()
    {
        yPosition =  yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(8f, yPosition, 0f);


        if ((yPosition > collision.yPosition && ySpeed > 0) ||
            (yPosition < collision.yPosition && ySpeed < 0))
        {
            ySpeed = ySpeed * -1f;
        }

        if (collision.yPosition > 4.4f)
        {
            ySpeed = 1;
        }
        else if (collision.yPosition < -4.4f)
        {
            ySpeed = -1;
        }
    }

    /// <summary>
    /// checks if the paddle hits a wall
    /// </summary>
    /// <param name="collider2D"></param>
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        Debug.Log("Auw!");

        if (collider2D.gameObject.CompareTag("horizontalWall"))
        {
            if (yPosition > 3.6f)
            {
                ySpeed = 0;
            }
            else if (yPosition < -3.6f)
            {
                ySpeed = 0;
            }

            ySpeed = ySpeed * -1f;
        }   
    }    
}

