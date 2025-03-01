using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_bomb_spawner : MonoBehaviour
{
    public GameObject itemPrefab;

    // to spawn objects and want to sperate items
    public float spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawnObject();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnObject()
    {
        // need position to spawn bombs
       // float xPos = Random.Range(-3f, 7f);
        float yPos = -2.9f;

        // use array to make fixed distance?
        float[] xPosition = { -3f, 1f, 5f, 8.5f };
        float xRadius;// = xPosition * spawnOffset;
        float yRadius;

        foreach (float x in xPosition)
        {
            xRadius = x * spawn;
            yRadius = yPos * spawn;
            Vector3 RandomPos = new Vector3(xRadius, yRadius, -1);
            Instantiate(itemPrefab, RandomPos, Quaternion.identity);
        }

        //Vector3 RandomPos = new Vector3(xRadius, yRadius, -1);
        //Instantiate(itemPrefab, RandomPos, Quaternion.identity);

    }
}
