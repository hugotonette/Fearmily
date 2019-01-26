using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed = 1f;
    Transform currentPatrolPoint;
    private Vector3 direction = Vector3.up;
    int patrolIndex;
    private SpriteRenderer _sprite;
    public GameObject enemySprite;

    void Start (){
        patrolIndex = 0;
        currentPatrolPoint = patrolPoints[patrolIndex];

    }

    void Awake(){
        _sprite = enemySprite.GetComponent<SpriteRenderer>();
    }

    void Update(){
        this.transform.Translate(direction * Time.deltaTime * speed);
        if(Vector3.Distance(transform.position, currentPatrolPoint.position) < .1f)
        {

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

        Vector3 pointDir = currentPatrolPoint.position - transform.position;

        if(pointDir.x < 0){
            Debug.Log("Indo pra esquerda, vira");
            _sprite.flipX = true;
        }else{
            Debug.Log("Indo pra direita, normal");
            _sprite.flipX = false;
        }
        float angle = Mathf.Atan2(pointDir.y, pointDir.x) * Mathf.Rad2Deg - 90f;

        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        this.transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180f);
    }
}
