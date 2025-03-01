using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteries_producer : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject particles;
    public float r;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        { //preferred since it adds difficulty
            spawnObject();
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.B))
        {
            spawnObject();
        }*/
    }

    void spawnObject()
    {
        Vector3 randomPos = Random.insideUnitCircle * r;
        Instantiate(itemPrefab, randomPos, Quaternion.identity);
        Instantiate(particles, randomPos, Quaternion.identity);


    }
}
