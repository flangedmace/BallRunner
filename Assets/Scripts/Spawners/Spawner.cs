using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] protected Spawned Template;
    [SerializeField] protected Transform[] SpawnPoints;
    [SerializeField] protected float SpawnInterval;

    protected float ElapseTime = 0f;

    private void Update()
    {
        if(ElapseTime > SpawnInterval)
        {
            Spawn();

            ElapseTime = 0f;
        }

        ElapseTime += Time.deltaTime;
    }

    protected virtual void Spawn() { }
}
