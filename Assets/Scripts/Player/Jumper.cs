using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpPower;

    private bool _grounded = true;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _grounded)
        {
            _rigidbody.AddForce(new Vector2(0, _jumpPower));
            _grounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Ground>(out Ground ground))
        {
            _grounded = true;
        }
    }
}
