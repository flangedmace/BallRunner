using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandState : State
{
    [SerializeField] private Animator _animator;

    private void OnEnable()
    {
        _animator.Play("stand");
        Debug.Log("StandState");
    }
}
