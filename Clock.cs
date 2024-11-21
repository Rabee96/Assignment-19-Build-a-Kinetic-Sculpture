using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public float offset = 0f;
    public float magnitude = 0f;
    public float velocity = 1f;
    private float angle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle+=0.01f;
        float angleZ = velocity * (angle+offset);
        transform.rotation = Quaternion.Euler(new Vector3(0f,0f,angleZ));

    }
}
