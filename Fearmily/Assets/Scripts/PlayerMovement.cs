using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Controls PlayerControl;
    public float MoveSpeed = 10;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
       if (Input.GetKey(PlayerControl.MoveUp) || Input.GetKey(PlayerControl.MoveUpAlt))
            _rb.velocity = new Vector2(0, MoveSpeed);
        else if (Input.GetKey(PlayerControl.MoveDown) || Input.GetKey(PlayerControl.MoveDownAlt))
            _rb.velocity = new Vector2(0, -MoveSpeed);
        else if (Input.GetKey(PlayerControl.MoveLeft) || Input.GetKey(PlayerControl.MoveLeftAlt))
            _rb.velocity = new Vector2(-MoveSpeed, 0);
        else if (Input.GetKey(PlayerControl.MoveRight) || Input.GetKey(PlayerControl.MoveRightAlt))
            _rb.velocity = new Vector2(MoveSpeed, 0);
        else
            _rb.velocity = new Vector2(0, 0);
    }
}