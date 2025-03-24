using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;  
    public Vector3[] spawnPositions;  
    float spawnTime = 1.8f;
    private List<GameObject> spawnedObjects = new List<GameObject>();  
    private Queue<int> lastIndexes = new Queue<int>();
    public int maxRepeats = 1; 


    private void Start()
    {
        
        StartCoroutine(SpawnObjectAtRandomIntervals());
    }

    void Update()
    {

    }
    public void AddLevel(float level)
    {
        spawnTime = Mathf.Max(0.8f, spawnTime + level);
        Debug.LogWarning("AddLevel bien appelé " + spawnTime + " level " + level );
    }

    
    private IEnumerator SpawnObjectAtRandomIntervals()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);

            
            int newIndex;
            do
            {
                newIndex = Random.Range(0, spawnPositions.Length);
            } 
            while (lastIndexes.Contains(newIndex) && lastIndexes.Count >= maxRepeats);

            
            lastIndexes.Enqueue(newIndex);
            if (lastIndexes.Count > maxRepeats)
            {
                lastIndexes.Dequeue();
            }

            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPositions[newIndex], Quaternion.identity);
            spawnedObject.SetActive(true);
            spawnedObjects.Add(spawnedObject);

            Destroy(spawnedObject, 8f);
        }
    }
}
