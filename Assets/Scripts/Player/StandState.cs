using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandState : State
{
    [SerializeField] private Animator _animator;
    [SerializeField] private AnimationClip _stand;

    private void Start()
    {
        _animator.Play(_stand.name);
    }
}
