using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Controls PlayerControl;
    public float MoveSpeed = 10;

    private Rigidbody2D _rb;
    private Animator principalAnimator;
    private Animation principalAnimation;

    private void Awake()
    {
        _rb = this.gameObject.GetComponent<Rigidbody2D>();
        principalAnimator = GameObject.Find("Principal").GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
       if (Input.GetKey(PlayerControl.MoveUp) || Input.GetKey(PlayerControl.MoveUpAlt))
        {
            principalAnimator.SetBool("movimentando", true);
            _rb.velocity = new Vector2(0, MoveSpeed);
        }
        else if (Input.GetKey(PlayerControl.MoveDown) || Input.GetKey(PlayerControl.MoveDownAlt))
        {
            principalAnimator.SetBool("movimentando", true);
            _rb.velocity = new Vector2(0, -MoveSpeed);
        }
        else if (Input.GetKey(PlayerControl.MoveLeft) || Input.GetKey(PlayerControl.MoveLeftAlt))
        {
            principalAnimator.SetBool("movimentando", true);
            _rb.velocity = new Vector2(-MoveSpeed, 0);
        }
        else if (Input.GetKey(PlayerControl.MoveRight) || Input.GetKey(PlayerControl.MoveRightAlt))
        {
            principalAnimator.SetBool("movimentando", true);
            _rb.velocity = new Vector2(MoveSpeed, 0);
        }
        else
        {
            _rb.velocity = new Vector2(0, 0);
            principalAnimator.SetBool("movimentando", false);
        }

            
    }
}