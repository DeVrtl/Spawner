using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyTemplates;
    [SerializeField] private Transform[] _spawnerPoints;

    
    private int _randomPosition;
    private float _timeBetweenSpawns;
    private float _startTimeBetweenSpawns = 2f;

    private void Start()
    {
        _timeBetweenSpawns = _startTimeBetweenSpawns;
    }

    private void Update()
    {
        int random;

        if (_timeBetweenSpawns <= 0)
        {
            random = Random.Range(0, _enemyTemplates.Length);
            _randomPosition = Random.Range(0, _spawnerPoints.Length);

            Instantiate(_enemyTemplates[random], _spawnerPoints[_randomPosition].transform.position, Quaternion.identity);

            _timeBetweenSpawns = _startTimeBetweenSpawns;
        }
        else
        {
            _timeBetweenSpawns -= Time.deltaTime;
        }
    }
}
