using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNAPart : MonoBehaviour
{
    float displacementTri = 0f;
    public float delay = 0f;
    public float offset = 0f;
    public float magnitude = 0f;
    public float velocity = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displacementTri+=0.01f;
        transform.rotation = Quaternion.Euler(new Vector3(0f,velocity * (displacementTri+offset),0f));

    }
}
