using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject circlePrefab = null;
    [SerializeField] float maxSpawnRange = 5f;
    [SerializeField] float minSpawnRange = 2.5f;
    [SerializeField] float spawnRate = 1f;

    void Start()
    {
        InvokeRepeating("SpawnCircle", 1f, spawnRate);
    }

    private void SpawnCircle()
    {
        var randomPosition = Random.insideUnitCircle * maxSpawnRange;
        if (randomPosition.sqrMagnitude < minSpawnRange) { return; }

        Instantiate(circlePrefab, randomPosition, Quaternion.identity);
    }
}
