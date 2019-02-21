﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void Move(float _velocity)
    {
        rb2d.velocity = new Vector2(_velocity, rb2d.velocity.y);
    }

    public void Jump(float _jumpForce)
    {
        rb2d.AddForce(new Vector2(rb2d.velocity.x, _jumpForce), ForceMode2D.Impulse);
    }
}
