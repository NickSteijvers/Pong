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
    public float xPosition = 2f;
    public static float yPosition = 2f;
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    public TMP_Text scoreText;
    public int leftscore = 0;
    public int rightscore = 0;
    public int winScore = 10;
    private int _score;

    // Start is called before the first frame update

    void resetBall()
    {
        xPosition = 0f;
        yPosition = Random.Range(-4f,4f);
        xSpeed = 1f;
        ySpeed = 1f;
    }
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
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
