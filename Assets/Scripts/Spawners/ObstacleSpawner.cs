using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ObstacleSpawner : Spawner
{
    [Range(0f, 1f), SerializeField] protected float DoubleObstacleChance;

    protected override void Spawn()
    {
        if (Random.value < DoubleObstacleChance)
        {
            for (int i = 0; i < SpawnPoints.Length; i++)
            {
                Instantiate(Template, SpawnPoints[i]);
            }
        }
        else
        {
            Instantiate(Template, SpawnPoints[Random.Range(0, SpawnPoints.Length)]);
        }
    }
}
