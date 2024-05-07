using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   public EnemyAI enemyPrefab;
    public List<Transform> patrolPoints;

    public int enemiesMaxCount = 5;
    public float delay = 2;
    public float timer;

    private float _timeLastSpawned;

    
    public PlayerController player;
    public List<Transform> _spawnerPoints;
    public List<EnemyAI> _enemies;
    void Start()
    {
        _spawnerPoints = new List<Transform>(transform.GetComponentsInChildren<Transform>());
        _enemies = new List<EnemyAI>();

    }

    // Update is called once per frame
    void Update()
    {
        for (var i = 0; i < _enemies.Count; i++)
        {
            if (_enemies[i].IsAlive()) continue;
            _enemies.RemoveAt(i);
            i--;
        }
        if (_enemies.Count >= enemiesMaxCount) return;
        if (Time.time - _timeLastSpawned < delay) return;
        CreateEnemy();
    }

    private void CreateEnemy()
    {
        
        var enemy = Instantiate(enemyPrefab);
        enemy.transform.position = _spawnerPoints[Random.Range(0,2)].position;
        
        enemy.player = player;

        enemy.patrolPoints = patrolPoints;
        _enemies.Add(enemy);
        _timeLastSpawned = Time.time;
       
    }
}
