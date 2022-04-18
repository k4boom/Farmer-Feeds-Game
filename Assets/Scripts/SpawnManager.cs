using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private float XspawnRange = 20;
    private float ZspawnRange = 25;
    private float startDelay = 5;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal(){
        Vector3 spawnPos = new Vector3(Random.Range(XspawnRange, -XspawnRange), 0, ZspawnRange);
        int animalIndex = Random.Range(0, animals.Length);
        Instantiate(animals[animalIndex], spawnPos, animals[animalIndex].transform.rotation);
    }
}
