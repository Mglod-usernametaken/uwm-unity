using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3z1 : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 startPosition;
    private int rotationCount = 0;
    private float side = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentSide)
        {
            case 0:
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                if (transform.position.x >= startPosition.x + sideLength) 
                {
                    transform.Rotate(0,90,0);
                    rotationCount++;
                }
                break;

            case 1:
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                if (transform.position.z >= startPosition.z + sideLength) 
                {
                    transform.Rotate(0,90,0);
                    rotationCount++;
                }
                break;

            case 2:
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                if (transform.position.x <= startPosition.x) 
                {
                    transform.Rotate(0,90,0);
                    rotationCount++;
                }
                break;

            case 3:
                transform.Translate(Vector3.back * speed * Time.deltaTime);
                if (transform.position.z >= startPosition.z)
                {
                    transform.Rotate(0,90,0);
                    rotationCount++;
                }
                break;

    }
    }
}
