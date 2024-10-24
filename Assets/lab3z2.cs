using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3z1 : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 startPosition;
    private int direction = 1;
    private float distance = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
        if (Vector3.Distance(startPosition, transform.position) >= distance) {
            direction *= -1;
            startPosition = transform.position;
        
    }
    }
}
