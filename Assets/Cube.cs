using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Vector3 p1 = new Vector3(-5, 0, 0);
    public Vector3 p2 = new Vector3(5, 0, 0);
    public float speed = 2.0f;
    Vector3 v = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        v = p2 - p1;
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x + (2.0f*Time.deltaTime); //秒速2m
        if (x > p2.x)
        {
            x = p1.x;
        }
        transform.position = new Vector3(x, p1.y, p1.z);
    }
}
