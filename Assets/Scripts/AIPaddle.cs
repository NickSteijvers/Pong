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
    public float yPosition = 2f;
    public float ySpeed = 2f;

    // Start is called before the first frame update

    void Start()
    {
        transform.position = new Vector3(8f, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        yPosition =  yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(8f, yPosition, 0f);

        //Debug.Log("Direction = " + collision.direction);
        //Debug.Log("ySpeed = " + ySpeed);

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

