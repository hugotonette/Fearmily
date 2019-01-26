﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed = 1f;
    Transform currentPatrolPoint;
    private Vector3 direction = Vector3.left;
    int patrolIndex;

    void Start (){
        patrolIndex = 0;
        currentPatrolPoint = patrolPoints[patrolIndex];

    }

    void Update(){
        this.transform.Translate(direction * Time.deltaTime * speed);
        if(Vector3.Distance(transform.position, currentPatrolPoint.position) < .1f)
        {
            if(direction == Vector3.left)
                direction = Vector3.right;
            else
                direction = Vector3.left;
            
            if(patrolIndex + 1 < patrolPoints.Length)
            {
                patrolIndex++;
            }
            else
            {
                patrolIndex = 0;
            }
            currentPatrolPoint = patrolPoints[patrolIndex];
        }
        // Vector3 pointDir = currentPatrolPoint.position - transform.position;
        // float angle = Mathf.Atan2(pointDir.y, pointDir.x) * Mathf.Rad2Deg - 90f;

        // Quaternion q = Quaternion.AngleAxis(angle, Vector3.foward);
        // this.transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180f);
    }
}
