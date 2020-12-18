using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Obstacle _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _spawnInterval;

    private float _runtime;

}
