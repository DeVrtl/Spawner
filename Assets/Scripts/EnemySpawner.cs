using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyTemplates;
    [SerializeField] private Transform[] _spawnPoints;

    
    private int _randomPosition;
    private float _staticTimeBetweenSpawns;
    private float _startTimeBetweenSpawns = 2f;

    private void Start()
    {
        _staticTimeBetweenSpawns = _startTimeBetweenSpawns;
    }

    private void Update()
    {
        int random;

        if (_staticTimeBetweenSpawns <= 0)
        {
            random = Random.Range(0, _enemyTemplates.Length);
            _randomPosition = Random.Range(0, _spawnPoints.Length);

            Instantiate(_enemyTemplates[random], _spawnPoints[_randomPosition].transform.position, Quaternion.identity);

            _staticTimeBetweenSpawns = _startTimeBetweenSpawns;
        }
        else
        {
            _staticTimeBetweenSpawns -= Time.deltaTime;
        }
    }
}
