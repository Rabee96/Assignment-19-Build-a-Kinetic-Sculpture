using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public float offset = 0f;
    public float magnitude = 0f;
    public float velocity = 1f;
    private float distance = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance+=0.01f;
        Vector3 positionX =  new (magnitude*Mathf.Cos((velocity*distance) + offset),59.1f,181.6f);
        transform.position = positionX;
    }
}
