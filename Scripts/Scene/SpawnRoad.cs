using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoad : MonoBehaviour
{
    public GameObject objectToSpawn;  
    public Vector3 spawnPosition = new Vector3(0f, 0f, 0f);  
    public float spawnTime = 5f;  
    public float destroyTime = 8f;
    private List<GameObject> spawnedObjects = new List<GameObject>();  

    void Start()
    {
        StartCoroutine(SpawnRoads());
    }

    private IEnumerator SpawnRoads()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime); 

           
            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

            
            spawnedObjects.Add(spawnedObject);

            
            Destroy(spawnedObject, destroyTime);
        }
    }
}
