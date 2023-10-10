using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UIElements;
using UnityEngine.UI;
using JetBrains.Annotations;

public class collision : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    float pointleft = 0;
    float pointright = 0;
    private int _score;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;
        //xPosition += xSpeed * Time.deltaTime; short version
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Auw!");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            Debug.Log("my head or my feet");
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalWallright"))
        {
            Debug.Log("my butt or my crotch");
            xSpeed = xSpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalWallleft"))
        {
            Debug.Log("my butt or my crotch");
            xSpeed = xSpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("right paddle"))
        {
            Debug.Log("my butt or my crotch");
            xSpeed = xSpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("left paddle"))
        {
            Debug.Log("my butt or my crotch");
            xSpeed = xSpeed * -1f;
        }
        if (collision.gameObject.CompareTag("verticalWallleft"))
        {
            Debug.Log("point added left");
            pointleft = pointleft + 1f;
            Debug.Log((int)pointleft);
            xPosition = 0f;
            yPosition = 0f;
        }
        else if (collision.gameObject.CompareTag("verticalWallright"))
        {
            Debug.Log("point added right");
            pointright = pointright + 1f;
            Debug.Log((int)pointright);
            xPosition = 0f;
            yPosition = 0f;
        }

    }
}
