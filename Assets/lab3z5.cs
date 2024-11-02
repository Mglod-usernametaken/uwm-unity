using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab; 
    public GameObject plane; 

    void Start()
    {
        SpawnCubes();
    }

    void SpawnCubes()
    {
        for (int i = 0; i < 10; i++)
        {
            float xPos = Random.Range(-4.8f, 4.8f); 
            float zPos = Random.Range(-4.8f, 4.8f); 
            Vector3 spawnPosition = new Vector3(xPos, 1f, zPos); 

            Instantiate(cubePrefab, spawnPosition, Quaternion.identity); 
        }
    }
}

