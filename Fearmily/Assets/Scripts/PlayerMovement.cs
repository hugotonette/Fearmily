using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;

    private Controls _playerControl;

    private void Awake()
    {
        _playerControl = gameObject.transform.Find("Controls").GetComponent<Controls>();
    }

    private void FixedUpdate()
    {
        if(Input.GetKeyDown(_playerControl.MoveUp) || Input.GetKeyDown(_playerControl.MoveUpAlt)){
            
        }
    }

}