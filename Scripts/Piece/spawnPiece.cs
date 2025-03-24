using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPiece : MonoBehaviour
{
    public GameObject objectToSpawn;  
    public Vector3[] spawnPositions;  
    float spawnTime = 20f;
    private List<GameObject> spawnedObjects = new List<GameObject>();  


    private void Start()
    {
        
        StartCoroutine(SpawnObjectAtRandomIntervals());
    }

    private IEnumerator SpawnObjectAtRandomIntervals()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(0f, 50f);
            Vector3 spawnPosition = spawnPositions[Random.Range(0, spawnPositions.Length)];

            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            Debug.LogWarning("PieceSpawn");
            spawnedObject.SetActive(true);
            spawnedObjects.Add(spawnedObject);

            Destroy(spawnedObject, 8f);
        }
    }
}
