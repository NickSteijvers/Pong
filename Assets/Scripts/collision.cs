using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UIElements;
using UnityEngine.UI;
using JetBrains.Annotations;
using TMPro;



public class collision : MonoBehaviour
{
    //variables
    public float xPosition = 2f;
    public static float yPosition = 2f;
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    public TMP_Text scoreText;
    public int leftscore = 0;
    public int rightscore = 0;
    public int winScore = 10;
    private int _score;

    /// <summary>
    /// It resets the ball back to x position 0 and y position is somewhere between y = 4 and y = -4
    /// </summary>
    void resetBall() 
    {
        xPosition = 0f;
        yPosition = Random.Range(-4f,4f);
        xSpeed = 1f;
        ySpeed = 1f;
    }

    /// <summary>
    /// sets the position of the ball to the same value as the xPosition and yPosition variables
    /// </summary>
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    /// <summary>
    /// This piece of code moves the ball and checks if the score is high enough and it says who has won.
    /// </summary>
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;

        float oldYPosition = yPosition;

        yPosition = yPosition + ySpeed * Time.deltaTime;

        transform.position = new Vector3(xPosition, yPosition, 0f);

        if(leftscore >= winScore)
        {
            scoreText.text = "Left player has won";
            xPosition = 0f;
            yPosition = 0f;
        }
        else if (rightscore >= winScore)
        {
            scoreText.text = "Right player has won";
            xPosition = 0f;
            yPosition = 0f;
        }

        
    }
    
    /// <summary>
    /// It checks if the ball hits the walls or if it hits the paddles and changes the speed based on what it hits.
    /// if it hits the walls on the left and on the rigth it adds a point to the scoreboard
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Auw!");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            //Debug.Log("my head or my feet");
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalWallright"))
        {
            //Debug.Log("my butt or my crotch");
            xSpeed = xSpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalWallleft"))
        {
            //Debug.Log("my butt or my crotch");
            xSpeed = xSpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("right paddle"))
        {
            //Debug.Log("my butt or my crotch");
            xSpeed = xSpeed * -1.1f;
        }
        else if (collision.gameObject.CompareTag("left paddle"))
        {
            //Debug.Log("my butt or my crotch");
            xSpeed = xSpeed * -1.1f;
        }
        if (collision.gameObject.CompareTag("verticalWallleft"))
        {
            //Debug.Log("point added left");
            //Debug.Log((int)rightscore);
            resetBall();
            rightscore++;
            scoreText.text = leftscore +" - " + rightscore;
        }
        else if (collision.gameObject.CompareTag("verticalWallright"))
        {
            //Debug.Log("point added right");
            //Debug.Log((int)leftscore);
            resetBall();
            leftscore++;
            scoreText.text = leftscore + " - " + rightscore;
        }
    }
}
