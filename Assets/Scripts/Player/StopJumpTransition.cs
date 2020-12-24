using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopJumpTransition : Transition
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Ground>(out Ground ground))
        {
            NeedTransit = true;
        }
    }
}
