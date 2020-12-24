using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Spawned : MonoBehaviour
{
    [ Min(0), SerializeField] private float _moveSpeed;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _suicideTime;

    private float _elapseTime = 0f;

    private void Start()
    {
        _rigidbody.AddForce(new Vector2(-_moveSpeed, 0f));
    }

    private void Update()
    {
        _elapseTime += Time.deltaTime;

        if(_elapseTime > _suicideTime)
        {
            Destroy(gameObject);
        }
    }
}
