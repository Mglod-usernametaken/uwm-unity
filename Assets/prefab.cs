using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab : MonoBehaviour
{
    public GameObject myPrefab;

    void Start()
    {
        Instantiate(myPrefab, new Vector3(0,0,0), Quaternion.identity);
    }

    void Update()
    {
        
    }
}
