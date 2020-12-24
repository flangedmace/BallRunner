using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandState : State
{
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator.Play("stand");
    }
}
