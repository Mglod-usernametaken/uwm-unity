using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3z6 : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 startPosition;

    public Transform target;
    float smoothTime = 1.0f;
    float yVelocity = 1.0f;



    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);
        transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
    }
}

