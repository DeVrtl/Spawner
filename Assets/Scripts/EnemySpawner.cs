using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemy;
    [SerializeField] private Transform[] _spawners;
    [SerializeField] private float _startTimeBetweenSpawns;

    private int _random;
    private int _randomPosition;
    private float _timeBetweenSpawns;

    private void Start()
    {
        _timeBetweenSpawns = _startTimeBetweenSpawns;
    }

    private void Update()
    {
        if (_timeBetweenSpawns <= 0)
        {
            _random = Random.Range(0, _enemy.Length);
            _randomPosition = Random.Range(0, _spawners.Length);

            Instantiate(_enemy[_random], _spawners[_randomPosition].transform.position, Quaternion.identity);

            _timeBetweenSpawns = _startTimeBetweenSpawns;
        }
        else
        {
            _timeBetweenSpawns -= Time.deltaTime;
        }
    }
}
