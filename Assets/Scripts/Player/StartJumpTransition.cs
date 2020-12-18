using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartJumpTransition : Transition
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NeedTransit = true;
        }
    }
}
