using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorNew : MonoBehaviour
{
	public GameObject VisionField;
	public GameObject BrotherSprite;
	public Transform[] PatrolPoints;
	[Space]
	public float speed = 1f;

	private Transform _currentPatrolPoint;
	private Vector3 _direction = Vector3.up;
	private int _patrolIndex;
	public GameObject Vision;
	

	void Start()
	{
		_patrolIndex = 0;
		Vision = GameObject.Find("Vision Field");
		_currentPatrolPoint = PatrolPoints[_patrolIndex];
	}

	void FixedUpdate()
	{
		this.transform.Translate(_direction * Time.deltaTime * speed);
		VisionField.transform.position = this.transform.position;

		if (Vector3.Distance(transform.position, _currentPatrolPoint.position) < .1f)
		{
			if (_patrolIndex + 1 < PatrolPoints.Length)
				_patrolIndex++;
			else
				_patrolIndex = 0;

			_currentPatrolPoint = PatrolPoints[_patrolIndex];
		}
		
		Vector3 pointDir = _currentPatrolPoint.position - transform.position;
		
		float angle = Mathf.Atan2(pointDir.y, pointDir.x) * Mathf.Rad2Deg - 90f;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		this.transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180f);

		if (pointDir.x < 0)
			BrotherSprite.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
		else if (pointDir.x > 0)
			BrotherSprite.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
	}
}
