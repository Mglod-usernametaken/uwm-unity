using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3z4 : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    private void Update() {
        Vector3 inputVector = new Vector3(0,0,0);
        if (Input.GetKey(KeyCode.I)) {
            inputVector.z = +1;
        }
        if (Input.GetKey(KeyCode.K)) {
            inputVector.z = -1;
        }
        if (Input.GetKey(KeyCode.J)) {
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.L)) {
            inputVector.x = +1;
        }
        inputVector = inputVector.normalized;

        Vector3 movement = inputVector * Time.deltaTime * speed;

        transform.position += movement;

        Debug.Log(inputVector);
    }
}

