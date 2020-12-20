using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopJumpTransition : Transition
{
    [SerializeField] private Animator _animator;


    private void Update()
    {
        if (/*_animator.GetCurrentAnimatorStateInfo(0).IsName("jump") && */_animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.95f)
        {
            NeedTransit = true;
        }
    }
}
