using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class JumpState : State
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpPower;

    private void OnEnable()
    {
        _rigidbody.AddForce(new Vector2(0, _jumpPower));
    }
}
