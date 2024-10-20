using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float force = 5.0f;
    Rigidbody rb;

    // Start is called once.
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate dotyczy fizyki, wywołuje się n razy na sekundę
    void FixedUpdate()
    {
        // składowa y wektora prędkości
        if(rb.velocity.y == 0)
        {
            // działamy siłą na ciało A :)
            rb.AddForce(Vector3.left * force, ForceMode.Impulse);
        }
    }
        
}
