using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    public GameObject[] spawnTrash;
    public Transform[] spawnPoint;
    public float startSpawnerInterval;
    public float spawnerInterval;
    public int numberOfTrash;
    public int nowTrash;
    public int randTrash;
    public int randPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnerInterval = startSpawnerInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnerInterval < 0 && nowTrash < numberOfTrash) 
        {
            randTrash = Random.Range(0, spawnTrash.Length);
            randPoint = Random.Range(0, spawnPoint.Length);

            Instantiate(spawnTrash[randTrash], spawnPoint[randPoint].transform.position, Quaternion.identity);

            spawnerInterval = startSpawnerInterval;
            nowTrash++;
        }

        else
        {
            spawnerInterval -= Time.deltaTime;
        }
    }
}
