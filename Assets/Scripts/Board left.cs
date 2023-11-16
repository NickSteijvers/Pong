using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boardleft : MonoBehaviour
{
    //variables
    public float xPosition = -8f;
    public float yPosition = 0f;


    /// <summary>
    /// puts board in its start position
    /// </summary>
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    /// <summary>
    /// moves board
    /// </summary>
    void Update()
    {
        yPosition = yPosition + 0.001f * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }
}
