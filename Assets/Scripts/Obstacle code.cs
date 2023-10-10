using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Obstaclecode : MonoBehaviour
{
    public string leftOrRight;
    public float maxValue = 20f;
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float ySpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
        xPosition = Random.Range(-4f, 4f);
        yPosition = Random.Range(-20f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
        if (yPosition > maxValue)
        {
            yPosition = -20f;
        }
    }
}
