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
    private GameObject _brotherSprite;

    void Start (){
        patrolIndex = 0;
        currentPatrolPoint = patrolPoints[patrolIndex];

    }

    void Awake(){
        //_sprite = enemySprite.GetComponent<SpriteRenderer>();
        _brotherSprite = GameObject.Find("Brother");
    }

    void FixedUpdate(){
        this.transform.Translate(direction * Time.deltaTime * speed);
        _brotherSprite.transform.position = this.transform.position;

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

		if (pointDir.x < 0)
		{
			_brotherSprite.transform.rotation = Quaternion.Euler(0, -180, 0);
		}
		else if (pointDir.x > 0)
		{
			_brotherSprite.transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		float angle = Mathf.Atan2(pointDir.y, pointDir.x) * Mathf.Rad2Deg - 90f;

        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        this.transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180f);
    }
}
