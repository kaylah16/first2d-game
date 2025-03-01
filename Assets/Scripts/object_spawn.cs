using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawn : MonoBehaviour
{
    public GameObject itemPrefab;

    // to spawn object
    public float spawn;
    void Start()
    {
         for(int i = 0; i < 7; i++)
         {
             spawnObject();
         }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObject(){
        // need position to spawn batteries
        float xPos = Random.Range(-7f, 7f); 
        float yPos = Random.Range(-2.5f, -1f);
        float xRadius = xPos * spawn;
        float yRadius = yPos * spawn;
        Vector3 RandomPos = new Vector3 (xRadius, yRadius, -1);
        Instantiate(itemPrefab, RandomPos, Quaternion.identity);

    }
}
