using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3z3 : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 startPosition;
    private Vector3 direction = Vector3.right; // Inicjalizuj kierunek
    private float distance = 10.0f;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (Vector3.Distance(startPosition, transform.position) >= distance)
        {
            direction = Quaternion.Euler(0, 90, 0) * direction; // Zmiana kierunku o 90 stopni
            startPosition = transform.position; // Ustaw nową pozycję startową
        }
    }
}

