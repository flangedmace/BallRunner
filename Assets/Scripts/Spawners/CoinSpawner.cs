using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : Spawner
{
    [SerializeField] private int _minCoinsInRow;
    [SerializeField] private int _maxCoinsInRow;
    [SerializeField] private float _intervalOfCoinsInRow;

    private int _spawnPointNumber;
    private int _coinsInRow;

    private void Start()
    {
        ElapseTime = SpawnInterval / 2;
    }

    protected override void Spawn()
    {
        _spawnPointNumber = Random.Range(0, SpawnPoints.Length);
        _coinsInRow = Random.Range(_minCoinsInRow, _maxCoinsInRow + 1);

        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        for (int i = 0; i < _coinsInRow; i++)
        {
            yield return new WaitForSeconds(_intervalOfCoinsInRow);
            Instantiate(Template, SpawnPoints[_spawnPointNumber]);
        }
    }
}
