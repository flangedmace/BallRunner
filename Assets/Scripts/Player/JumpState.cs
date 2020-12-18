using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : State
{
    [SerializeField] private Animator _animator;

    private void OnEnable()
    {
        _animator.Play("jump");
        Debug.Log("JumpState");
    }
}
