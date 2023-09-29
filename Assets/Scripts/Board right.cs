using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Boardright : MonoBehaviour
{
    public float xPosition = 8f;
    public float yPosition = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        yPosition = yPosition + 0.001f * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }
}
