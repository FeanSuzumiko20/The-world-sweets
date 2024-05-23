﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    public List<Transform> patrolPoints;
    public PlayerController player;
    public float ViewAngle;
    public float damage = 30;
    public Animator animator;
    public Fire Trigger;
    private NavMeshAgent _navMeshAgent;
    private bool _isPlayerNoticed;
    private PlayerHealth _playerHealth;
    private EnemyHealth _enemyHealth;
    

    public bool IsAlive()
    {
        return _enemyHealth.IsAlive();

    }
    public void InitComponentLinks()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _playerHealth = player.GetComponent<PlayerHealth>();
        _enemyHealth = GetComponent<EnemyHealth>();

    }
    private void Start()
    {
        InitComponentLinks();
        PickNewPatrolPoint();
    }
    

    private void NoticePlayerUpdate()
    {
        var direction = player.transform.position - transform.position;

        if (Vector3.Angle(transform.forward, direction) < ViewAngle && Trigger.OnZone == true)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position + Vector3.up, direction, out hit) )
            {
                if (hit.collider.gameObject == player.gameObject )
                {
                    _isPlayerNoticed = true;
                    animator.SetTrigger("noticed");
                }
            }
        }
        if (_playerHealth._currentValue <= 0)
        {
            PickNewPatrolPoint();
        }
    }
    private void Update()
    {
        NoticePlayerUpdate();
        ChaseUpdate();
        PatrolUpdate();
        AttackUpdate();
       

    }

    private void PatrolUpdate()
    {
        if (!_isPlayerNoticed)
        {
            if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
            {
                PickNewPatrolPoint();
            }
        }
    }

    private void PickNewPatrolPoint()
    {

        _navMeshAgent.destination = patrolPoints[Random.Range(0, patrolPoints.Count)].position;
    }
    private void ChaseUpdate()
    {
        if (_isPlayerNoticed && Trigger.OnZone == true)
        {
            _navMeshAgent.destination = player.transform.position;
            
        }
        else
        {
            PickNewPatrolPoint();
        }
    }
    private void AttackUpdate()
    {
        if (_isPlayerNoticed)
        {
            if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance && Trigger.OnZone == true )
            {
                _playerHealth.DealDamage(damage * Time.deltaTime);
                animator.SetTrigger("hit");
            }
        }
    }
}

