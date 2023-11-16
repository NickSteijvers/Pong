using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Boardright : MonoBehaviour
{
    //variable
    public float xPosition = 8f;
    public float yPosition = 0f;

    /// <summary>
    /// desides start position
    /// </summary>
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    /// <summary>
    /// moves the board
    /// </summary>
    void Update()
    {
        yPosition = yPosition + 0.001f * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }
}
