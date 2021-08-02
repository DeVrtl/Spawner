using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyTemplates;
    [SerializeField] private Transform[] _spawnPoints;

    
    private int _randomPosition;
    private float _timeBetweenSpawnsEnemy;
    private float _startTimeBetweenSpawns = 2f;

    private void Start()
    {
        _timeBetweenSpawnsEnemy = _startTimeBetweenSpawns;
    }

    private void Update()
    {
        int randomTemplate;

        if (_timeBetweenSpawnsEnemy <= 0)
        {
            randomTemplate = Random.Range(0, _enemyTemplates.Length);
            _randomPosition = Random.Range(0, _spawnPoints.Length);

            Instantiate(_enemyTemplates[randomTemplate], _spawnPoints[_randomPosition].transform.position, Quaternion.identity);

            _timeBetweenSpawnsEnemy = _startTimeBetweenSpawns;
        }
        else
        {
            _timeBetweenSpawnsEnemy -= Time.deltaTime;
        }
    }
}
